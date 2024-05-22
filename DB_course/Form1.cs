using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using StackExchange.Redis;
using System.Linq;

namespace DB_course
{
    public partial class Form1 : Form
    {
        private readonly ConnectionMultiplexer redis;

        public Form1()
        {
            InitializeComponent();
            redis = ConnectionMultiplexer.Connect("localhost"); 
        }

        private void DisplayDataInDataGridView(string keyPattern, DataGridView dataGridView)
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: keyPattern)
                .OrderBy(key => int.Parse(key.ToString().Split(':')[1])); 
            var rows = new List<DataGridViewRow>();

            foreach (var key in keys)
            {
                HashEntry[] entries = db.HashGetAll(key);
                var row = new DataGridViewRow();

                string[] keyParts = key.ToString().Split(':'); 

                row.Cells.Add(new DataGridViewTextBoxCell { Value = keyParts[1] }); 

                foreach (var entry in entries)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = entry.Value });
                }
                rows.Add(row);
            }

            dataGridView.Rows.Clear();
            dataGridView.Rows.AddRange(rows.ToArray());
        }

        private void btnGetClient_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView("client:*", dataGridViewClients);
        }

        private void btnGetAgent_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView("agent:*", dataGridViewAgents);
        }

        private void btnGetEstate_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView("estate:*", dataGridViewEstates);
        }

        private void btnGetContract_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView("contract:*", dataGridViewContracts);
        }

        private void btnGetPreference_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView("preference:*", dataGridViewPreferences);
        }
        private void btnGetClientById_Click(object sender, EventArgs e)
        {
            string clientId = txtClientId.Value.ToString(); 
            DisplayObjectById("client", clientId, dataGridViewClients); // Відображення даних клієнта за айді
        }

        private void btnGetAgentById_Click(object sender, EventArgs e)
        {
            string agentId = txtAgentId.Value.ToString(); // Отримання айді агента з numericUpDown
            DisplayObjectById("agent", agentId, dataGridViewAgents); // Відображення даних агента за айді
        }

        private void btnGetEstateById_Click_1(object sender, EventArgs e)
        {
            string estateId = txtEstateId.Value.ToString(); // Отримання айді нерухомості з numericUpDown
            DisplayObjectById("estate", estateId, dataGridViewEstates); // Відображення даних нерухомості за айді
        }

        private void btnGetContractById_Click(object sender, EventArgs e)
        {
            string contractId = txtContractId.Value.ToString(); // Отримання айді контракту з numericUpDown
            DisplayObjectById("contract", contractId, dataGridViewContracts); // Відображення даних контракту за айді
        }

        private void btnGetPreferenceById_Click(object sender, EventArgs e)
        {
            string preferenceId = txtPreferenceId.Value.ToString(); // Отримання айді вподобання з numericUpDown
            DisplayObjectById("preference", preferenceId, dataGridViewPreferences); // Відображення даних вподобання за айді
        }

        private void DisplayObjectById(string objectType, string id, DataGridView dataGridView)
        {
            string key = $"{objectType}:{id}"; 
            if (ObjectExists(key))
            {
                DisplayDataInDataGridView(key, dataGridView); 
            }
            else
            {
                dataGridView.Rows.Clear();
            }
        }

        private bool ObjectExists(string key)
        {
            IDatabase db = redis.GetDatabase();
            return db.KeyExists(key);
        }
        private void btnGetAgentByLastName_Click_1(object sender, EventArgs e)
        {
            string lastName = txtAgentLastName.Text.Trim(); 
            DisplayAgentByLastName(lastName); 
        }

        private void btnGetClientByPhoneNumber_Click_1(object sender, EventArgs e)
        {
            string phoneNumber = txtClientNumber.Text.Trim(); 
            DisplayClientByPhoneNumber(phoneNumber); 
        }

        // Метод для відображення даних агента за прізвищем
        private void DisplayAgentByLastName(string lastName)
        {
            IDatabase db = redis.GetDatabase();
            bool foundAgent = false; 

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "agent:*");
            foreach (var key in keys)
            {
                HashEntry[] entries = db.HashGetAll(key);
                foreach (var entry in entries)
                {
                    if (entry.Name.ToString().Equals("full_name", StringComparison.OrdinalIgnoreCase) && 
                        entry.Value.ToString().EndsWith(lastName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found agent with last name: {lastName}, Key: {key}");
                        DisplayDataInDataGridView(key, dataGridViewAgents);
                        foundAgent = true;
                        break; 
                    }
                }
                if (foundAgent) break; 
            }

            if (!foundAgent)
            {
                dataGridViewAgents.Rows.Clear();
            }
        }

        private void DisplayClientByPhoneNumber(string phoneNumber)
        {
            IDatabase db = redis.GetDatabase();
            bool foundClient = false;

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "client:*");
            foreach (var key in keys)
            {
                HashEntry[] entries = db.HashGetAll(key);
                foreach (var entry in entries)
                {
                    if (entry.Name.ToString().Equals("contact", StringComparison.OrdinalIgnoreCase) && 
                        entry.Value.ToString().Replace(" ", "").Equals(phoneNumber, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found client with phone number: {phoneNumber}, Key: {key}");
                        DisplayDataInDataGridView(key, dataGridViewClients);
                        foundClient = true;
                        break; 
                    }
                }
                if (foundClient) break; 
            }

            if (!foundClient)
            {
                dataGridViewClients.Rows.Clear();
            }
        }

        private void txtAgentLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtClientNumber_ValueChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtClientNumber.Text.Trim();
            if (!string.IsNullOrEmpty(phoneNumber)) 
            {
                DisplayClientByPhoneNumber(phoneNumber);
            }
            else
            {
                dataGridViewClients.Rows.Clear();
            }
        }
        private void AddRecordToDatabase(string keyPrefix, string[] attributeNames, string[] values, Action onSuccess)
        {
            if (attributeNames.Length != values.Length)
            {
                throw new ArgumentException("Кількість атрибутів має відповідати кількості значень.");
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(values[i]))
                {
                    MessageBox.Show($"Поле '{attributeNames[i]}' не може бути порожнім. Заповніть усі поля.");
                    return;
                }
            }

            IDatabase db = redis.GetDatabase();
            string recordKey = $"{keyPrefix}:{db.StringIncrement($"{keyPrefix}")}";
            HashEntry[] hashEntries = new HashEntry[attributeNames.Length];
            for (int i = 0; i < attributeNames.Length; i++)
            {
                hashEntries[i] = new HashEntry(attributeNames[i], values[i]);
            }

            db.HashSet(recordKey, hashEntries);

            onSuccess?.Invoke();
        }

        private void btnAddEstate_Click(object sender, EventArgs e)
        {
            string[] attributeNames = new string[]
            {
        "address",
        "type",
        "area",
        "rooms",
        "floor",
        "total_floors",
        "bathroom_type",
        "price",
        "agent_id"
            };

            string[] estateData = new string[]
            {
        txtAddEstateAddress.Text.Trim(),
        txtAddEstateType.Text.Trim(),
        txtAddEstateArea.Text.Trim(),
        txtAddEstateRooms.Text.Trim(),
        txtAddEstateFloor.Text.Trim(),
        txtAddEstateTotal.Text.Trim(),
        txtAddEstateBath.Text.Trim(),
        txtAddEstatePrice.Text.Trim(),
        txtAddEstateAgent.Text.Trim()
            };

            AddRecordToDatabase("estate", attributeNames, estateData, () =>
            {
                MessageBox.Show("Запис додано.");
                txtAddEstateAddress.Clear();
                txtAddEstateType.Clear();
                txtAddEstateArea.Value = txtAddEstateFloor.Minimum;
                txtAddEstateRooms.Value = txtAddEstateRooms.Minimum;
                txtAddEstateFloor.Value = txtAddEstateFloor.Minimum; // сброс значения NumericUpDown
                txtAddEstateTotal.Value = txtAddEstateTotal.Minimum; // сброс значения NumericUpDown
                txtAddEstateBath.Clear();
                txtAddEstatePrice.Value = txtAddEstatePrice.Minimum;
                txtAddEstateAgent.Value = txtAddEstateAgent.Minimum;
            });
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string[] attributeNames = new string[]
            {
        "client_name",
        "approx_price",
        "type",
        "contact",
        "preference_id"
            };
            string[] clientData = new string[]
            {
        txtAddClientName.Text.Trim(),
        txtAddAppPrice.Text.Trim(),
        txtAddType.Text.Trim(),
        txtAddClientContact.Text.Trim(),
        txtAddClientPreference.Text.Trim()
            };

            AddRecordToDatabase("client", attributeNames, clientData, () =>
            {
                MessageBox.Show("Запис додано.");
                txtAddClientName.Clear();
                txtAddAppPrice.Value = txtAddAppPrice.Minimum;
                txtAddType.Clear();
                txtAddClientContact.Value = txtAddClientContact.Minimum;
                txtAddClientPreference.Value = txtAddClientPreference.Minimum;
            });
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {
            string[] attributeNames = new string[]
            {
        "preference_text"
            };
            string[] preferenceData = new string[]
            {
        txtAddPreference.Text.Trim()
            };

            AddRecordToDatabase("preference", attributeNames, preferenceData, () =>
            {
                MessageBox.Show("Запис додано.");
                txtAddPreference.Clear();
            });
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            string[] attributeNames = new string[]
            {
        "price",
        "sign_date",
        "agent_id",
        "client_id",
        "estate_id"
            };
            string[] contractData = new string[]
            {
        txtAddContractPrice.Text.Trim(),
        txtAddContractDate.Text.Trim(),
        txtAddContractAgent.Text.Trim(),
        txtAddContractClient.Text.Trim(),
        txtAddContractEstate.Text.Trim()
            };

            AddRecordToDatabase("contract", attributeNames, contractData, () =>
            {
                MessageBox.Show("Запис додано.");
                txtAddContractPrice.Value = txtAddContractPrice.Minimum;
                txtAddContractAgent.Value = txtAddContractAgent.Minimum;
                txtAddContractClient.Value = txtAddContractClient.Minimum;
                txtAddContractEstate.Value = txtAddContractEstate.Minimum;
            });
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            string[] attributeNames = new string[]
            {
        "full_name",
        "job",
        "contact"
            };
            string[] agentData = new string[]
            {
        txtAddAgentName.Text.Trim(),
        txtAddAgentJob.Text.Trim(),
        txtAddAgentContact.Text.Trim()
            };

            AddRecordToDatabase("agent", attributeNames, agentData, () =>
            {
                MessageBox.Show("Запис додано.");
                txtAddAgentName.Clear();
                txtAddAgentJob.Clear();
                txtAddAgentContact.Value = txtAddAgentContact.Minimum;
            });
        }


        private void txtAddPreference_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateBath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstatePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateAgent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddEstateAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void btnClearAgent_Click(object sender, EventArgs e)
        {
            ClearAgentTable();
            dataGridViewAgents.Rows.Clear();
        }
        private void ClearAgentTable()
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "agent:*");
            foreach (var key in keys)
            {
                db.KeyDelete(key);
            }

            // Видалення хеш-номера
            db.KeyDelete("agent"); // Замініть "agent" на ім'я ключа вашої таблиці агентів, якщо воно відрізняється
        }
        private void btnClearClient_Click_1(object sender, EventArgs e)
        {
            ClearClientTable();
            dataGridViewClients.Rows.Clear();
        }
        private void ClearClientTable()
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "client:*");
            foreach (var key in keys)
            {
                db.KeyDelete(key);
            }

            // Видалення хеш-номера
            db.KeyDelete("client");
        }

        private void btnClearPreference_Click(object sender, EventArgs e)
        {
            ClearPreferenceTable();
            dataGridViewClients.Rows.Clear();
        }
        private void ClearPreferenceTable()
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "preference:*");
            foreach (var key in keys)
            {
                db.KeyDelete(key);
            }

            // Видалення хеш-номера
            db.KeyDelete("preference");
        }

        private void btnClearEstate_Click(object sender, EventArgs e)
        {
            ClearEstateTable();
            dataGridViewClients.Rows.Clear();
        }
        private void ClearEstateTable()
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "estate:*");
            foreach (var key in keys)
            {
                db.KeyDelete(key);
            }

            // Видалення хеш-номера
            db.KeyDelete("estate");
        }

        private void btnClearContract_Click(object sender, EventArgs e)
        {
            ClearContractTable();
            dataGridViewClients.Rows.Clear();
        }
        private void ClearContractTable()
        {
            IDatabase db = redis.GetDatabase();

            var keys = redis.GetServer("localhost", 6379).Keys(pattern: "contract:*");
            foreach (var key in keys)
            {
                db.KeyDelete(key);
            }

            // Видалення хеш-номера
            db.KeyDelete("contract");
        }
        // Метод для архівування запису за айді
        private void ArchiveRecord(string objectType, string id)
        {
            string key = $"{objectType}:{id}"; // Формування ключа за айді об'єкта
            IDatabase db = redis.GetDatabase();
            if (ObjectExists(key))
            {
                string fieldToArchive;
                switch (objectType)
                {
                    case "client":
                        fieldToArchive = "approx_price"; // Поле для клієнта
                        break;
                    case "agent":
                        fieldToArchive = "job"; // Поле для агента
                        break;
                    case "estate":
                        fieldToArchive = "price"; // Поле для нерухомості
                        break;
                    default:
                        MessageBox.Show($"Unknown object type: {objectType}");
                        return;
                }

                db.HashSet(key, fieldToArchive, "архівовано"); // Зміна значення поля на "archived"
                MessageBox.Show($"{objectType} з ID {id} архівовано.");
            }
            else
            {
                MessageBox.Show($"{objectType} p ID {id} не існує.");
            }
        }

        // Події натискання кнопок для архівування
        private void btnArchiveClient_Click_1(object sender, EventArgs e)
        {
            string clientId = txtClientArchId.Value.ToString(); // Отримання айді клієнта з numericUpDown
            ArchiveRecord("client", clientId); // Архівування клієнта за айді
        }

        private void btnArchiveAgent_Click_1(object sender, EventArgs e)
        {
            string agentId = txtAgentArchId.Value.ToString(); // Отримання айді агента з numericUpDown
            ArchiveRecord("agent", agentId); // Архівування агента за айді
        }

        private void btnArchiveEstate_Click_1(object sender, EventArgs e)
        {
            string estateId = txtEstateArchId.Value.ToString(); // Отримання айді нерухомості з numericUpDown
            ArchiveRecord("estate", estateId); // Архівування нерухомості за айді
        }
        // Додати кнопку для оновлення клієнта
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            string clientId = txtClientIdUpdate.Value.ToString(); // Отримання айді клієнта з numericUpDown
            string[] attributeNames = new string[] { "client_name", "approx_price", "type", "contact", "preference_id" };
            string[] newValues = new string[]
            {
        txtUpdateClientName.Text.Trim(),
        txtUpdateApproxPrice.Text.Trim(),
        txtUpdateType.Text.Trim(),
        txtUpdateContact.Text.Trim(),
        txtUpdatePreferenceId.Text.Trim()
            };

            UpdateRecordInDatabase("client", clientId, attributeNames, newValues); // Оновлення запису клієнта
        }

        private void btnUpdateEstate_Click_1(object sender, EventArgs e)
        {
            string estateId = txtEstateIdUpdate.Value.ToString(); // Отримання айді клієнта з numericUpDown
            string[] attributeNames = new string[] { "address", "type", "area", "rooms", "floor", "total_floors", "bathroom_type", "price", "agent_id" };
            string[] newValues = new string[]
            {
        txtUpdateEstateAddress.Text.Trim(),
        txtUpdateEstateType.Text.Trim(),
        txtUpdateEstateArea.Text.Trim(),
        txtUpdateEstateFloor.Text.Trim(),
        txtUpdateEstateFloor.Text.Trim(),
        txtUpdateEstateTotal.Text.Trim(),
        txtUpdateEstateBath.Text.Trim(),
        txtUpdateEstatePrice.Text.Trim(),
        txtUpdateEstateAgent.Text.Trim()
            };

            UpdateRecordInDatabase("estate", estateId, attributeNames, newValues); // Оновлення запису клієнта
        }

        private void btnUpdatePreference_Click(object sender, EventArgs e)
        {
            string preferenceId = txtPreferenceIdUpdate.Value.ToString(); // Отримання айді клієнта з numericUpDown
            string[] attributeNames = new string[] { "preference_text" };
            string[] newValues = new string[]
            {
        txtUpdatePreference.Text.Trim()
            };

            UpdateRecordInDatabase("preference", preferenceId, attributeNames, newValues); // Оновлення запису клієнта
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            string contractId = txtUpdateContractId.Value.ToString(); // Отримання айді клієнта з numericUpDown
            string[] attributeNames = new string[] { "price", "sign_date", "agent_id", "client_id", "estate_id" };
            string[] newValues = new string[]
            {
        txtUpdateContractPrice.Text.Trim(),
        txtUpdateContractDate.Text.Trim(),
        txtUpdateContractAgent.Text.Trim(),
        txtUpdateContractClient.Text.Trim(),
        txtUpdateContractEstate.Text.Trim()
            };

            UpdateRecordInDatabase("contract", contractId, attributeNames, newValues); // Оновлення запису клієнта
        }

        private void btnUpdateAgent_Click_1(object sender, EventArgs e)
        {
            string agentId = txtUpdateAgentId.Value.ToString(); // Отримання айді клієнта з numericUpDown
            string[] attributeNames = new string[] { "full_name", "job", "contact" };
            string[] newValues = new string[]
            {
        txtUpdateAgentName.Text.Trim(),
        txtUpdateAgentJob.Text.Trim(),
        txtUpdateAgentContact.Text.Trim()
            };

            UpdateRecordInDatabase("agent", agentId, attributeNames, newValues); // Оновлення запису клієнта
        }

        // Метод для оновлення запису в базі даних
        private void UpdateRecordInDatabase(string objectType, string id, string[] attributeNames, string[] values)
        {
            if (attributeNames.Length != values.Length)
            {
                throw new ArgumentException("Кількість атрибутів має відповідати кількості значень.");
            }

            IDatabase db = redis.GetDatabase();
            string key = $"{objectType}:{id}";

            if (!ObjectExists(key))
            {
                MessageBox.Show($"{objectType} з ID {id} не існує.");
                return;
            }

            // Отримання поточних значень
            HashEntry[] currentEntries = db.HashGetAll(key);
            Dictionary<string, string> currentData = currentEntries.ToDictionary(entry => entry.Name.ToString(), entry => entry.Value.ToString());

            List<HashEntry> hashEntriesToUpdate = new List<HashEntry>();

            for (int i = 0; i < attributeNames.Length; i++)
            {
                string currentValue = currentData.ContainsKey(attributeNames[i]) ? currentData[attributeNames[i]] : null;
                string newValue = values[i];

                // Якщо нове значення порожнє або дорівнює "0", залишити старе значення
                if (!string.IsNullOrEmpty(newValue) && newValue != "0")
                {
                    hashEntriesToUpdate.Add(new HashEntry(attributeNames[i], newValue));
                }
                else
                {
                    // Якщо нове значення порожнє або нуль, зберігається старе значення
                    hashEntriesToUpdate.Add(new HashEntry(attributeNames[i], currentValue));
                }
            }

            db.HashSet(key, hashEntriesToUpdate.ToArray());
            MessageBox.Show($"{objectType} з ID {id} оновлено.");
        }
        private void txtClientIdUpdate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEstateIdUpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateContractId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
