using PROG7312_POE_municipal_services_application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE_municipal_services_application.Local_Events_and_Announcements
{
    public partial class AddEventForm : Form
    {
        /// <summary>
        /// Declare an event queue to hold sample events.
        /// </summary>
        private Queue<EventsData> eventQueue = new Queue<EventsData>();

        /// <summary>
        /// dictionary used to count for the searches.
        /// </summary>
        private Dictionary<string, int> searchCounts = new Dictionary<string, int>();

        /// <summary>
        /// sortedDictionary to organize events by date
        /// </summary>
        private SortedDictionary<DateTime, Queue<EventsData>> eventDictionary = new SortedDictionary<DateTime, Queue<EventsData>>();

        /// <summary>
        /// defining a HashSet to store unique categories.
        /// </summary>
        private HashSet<string> uniqueCategories = new HashSet<string>();

        /// <summary>
        /// defining a stack to store search history.
        /// </summary>
        private Stack<string> searchHistoryStack = new Stack<string>();

        /// <summary>
        /// Initializes the AddEventForm and adds sample events to the queue.
        /// </summary>
        public AddEventForm()
        {
            InitializeComponent();
            SampleEvents();
            DisplayCategories();
            DisplayEvents();
        }


        /// <summary>
        /// Method used to display sample events in the flowLayoutPanel using sorted dictionaries.
        /// </summary>
        private void DisplayEvents()
        {
            // Clear the event dictionary before adding new events
            eventDictionary.Clear();

            // Organizing events into the SortedDictionary by date by looping through the eventQueue
            foreach (var eventItem in eventQueue)
            {
                if (!eventDictionary.ContainsKey(eventItem.Time))
                {
                    eventDictionary[eventItem.Time] = new Queue<EventsData>();
                }
                eventDictionary[eventItem.Time].Enqueue(eventItem); // Use Enqueue for Queue
            }

            // Check if there are any events in the dictionary and return a message if empty
            if (eventDictionary.Count == 0)
            {
                MessageBox.Show("No events to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear any existing controls to avoid duplicates
            flowLayoutPanel1.Controls.Clear();

            // Iterate through the eventDictionary and display each event in sorted order
            foreach (var kvp in eventDictionary)
            {
                foreach (var eventItem in kvp.Value)
                {
                    // Create an EventsUserControl for each event and set its properties
                    EventUserControl eventControl = new EventUserControl
                    {
                        EventName = eventItem.Name,
                        EventCategory = eventItem.Category,
                        EventDescription = eventItem.Description,
                        EventLocation = eventItem.Location,
                        EventTime = eventItem.Time,
                        EventImage = eventItem.Media
                    };

                    // Add the event control to the flowLayoutPanel to display it in the UI
                    flowLayoutPanel1.Controls.Add(eventControl);
                }
            }
        }


        /// <summary>
        /// Method to create mock events to be displayed in the form.
        /// </summary>
        private void SampleEvents()
        {
            // Community Meetings
            eventQueue.Enqueue(new EventsData(
                name: "Community Town Hall Meeting",
                category: "Community Meetings",
                description: "Discuss upcoming infrastructure projects with local council.",
                time: DateTime.Now.AddDays(-1),
                media: Image.FromFile(@"Pictures\ComMeeting.jpg"),
                location: "Town Hall",
                formattedTime: DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Neighborhood Watch Assembly",
                category: "Community Meetings",
                description: "Plan safety measures with the community and police department.",
                time: DateTime.Now.AddDays(7),
                media: Image.FromFile(@"Pictures\TownHall.jpg"),
                location: "Community Center",
                formattedTime: DateTime.Now.AddDays(7).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Festival
            eventQueue.Enqueue(new EventsData(
                name: "Annual Music and Food Festival",
                category: "Festival",
                description: "Experience local bands and food stalls in Rosebank.",
                time: DateTime.Now.AddDays(-5),
                media: Image.FromFile(@"Pictures\FoodFestival.jpeg"),
                location: "Gauteng",
                formattedTime: DateTime.Now.AddDays(-5).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Spring Flower Festival",
                category: "Festival",
                description: "Enjoy floral displays and gardening workshops.",
                time: DateTime.Now.AddDays(10),
                media: Image.FromFile(@"Pictures\Flowers.jpg"),
                location: "Botanical Gardens",
                formattedTime: DateTime.Now.AddDays(10).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Workshop
            eventQueue.Enqueue(new EventsData(
                name: "Career Development Workshop",
                category: "Workshop",
                description: "A workshop on building professional skills and networking.",
                time: DateTime.Now.AddDays(-3),
                media: Image.FromFile(@"Pictures\Workshop.jpg"),
                location: "Community Center",
                formattedTime: DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Digital Skills Workshop",
                category: "Workshop",
                description: "Learn essential digital skills for the workplace.",
                time: DateTime.Now.AddDays(3),
                media: Image.FromFile(@"Pictures\DigitalWorkshop.jpeg"),
                location: "Tech Hub",
                formattedTime: DateTime.Now.AddDays(3).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Health and Wellness
            eventQueue.Enqueue(new EventsData(
                name: "Free Health Check-Up Camp",
                category: "Health and Wellness",
                description: "Get a free health check-up by licensed professionals.",
                time: DateTime.Now.AddDays(2),
                media: Image.FromFile(@"Pictures\Health.jpg"),
                location: "Local Clinic",
                formattedTime: DateTime.Now.AddDays(2).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Yoga in the Park",
                category: "Health and Wellness",
                description: "Join a free yoga session in the park.",
                time: DateTime.Now.AddDays(5),
                media: Image.FromFile(@"Pictures\Yoga.jpg"),
                location: "Central Park",
                formattedTime: DateTime.Now.AddDays(5).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Arts and Culture
            eventQueue.Enqueue(new EventsData(
                name: "Art Exhibition: Local Artists",
                category: "Arts and Culture",
                description: "Explore paintings and sculptures by local artists.",
                time: DateTime.Now.AddDays(-2),
                media: Image.FromFile(@"Pictures\Art.jpg"),
                location: "Art Gallery",
                formattedTime: DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Cultural Dance Showcase",
                category: "Arts and Culture",
                description: "Witness traditional dances from various cultures.",
                time: DateTime.Now.AddDays(6),
                media: Image.FromFile(@"Pictures\Dance.jpg"),
                location: "Cultural Center",
                formattedTime: DateTime.Now.AddDays(6).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Volunteer Opportunities
            eventQueue.Enqueue(new EventsData(
                name: "Beach Clean-Up Volunteer Event",
                category: "Volunteer Opportunities",
                description: "Help clean the local beach.",
                time: DateTime.Now.AddDays(1),
                media: Image.FromFile(@"Pictures\Beach.jpg"),
                location: "Beachfront",
                formattedTime: DateTime.Now.AddDays(1).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Food Bank Donation Drive",
                category: "Volunteer Opportunities",
                description: "Assist in organizing and distributing food for the needy.",
                time: DateTime.Now.AddDays(4),
                media: Image.FromFile(@"Pictures\Food.jpg"),
                location: "Community Hall",
                formattedTime: DateTime.Now.AddDays(4).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Holiday Celebration
            eventQueue.Enqueue(new EventsData(
                name: "Christmas Carol Night",
                category: "Holiday Celebration",
                description: "Celebrate Christmas with carols and a community dinner.",
                time: DateTime.Now.AddDays(15),
                media: Image.FromFile(@"Pictures\Carol.jpg"),
                location: "Church Grounds",
                formattedTime: DateTime.Now.AddDays(15).ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Independence Day Parade",
                category: "Holiday Celebration",
                description: "Join the parade to celebrate our nation's independence.",
                time: DateTime.Now.AddDays(-10),
                media: Image.FromFile(@"Pictures\Freedom.jpg"),
                location: "Main Street",
                formattedTime: DateTime.Now.AddDays(-10).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // Government Service
            eventQueue.Enqueue(new EventsData(
                name: "Voter Registration Drive",
                category: "Government Service",
                description: "Get registered to vote in upcoming elections.",
                time: DateTime.Now.AddDays(-7),
                media: Image.FromFile(@"Pictures\Voting.jpg"),
                location: "City Hall",
                formattedTime: DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy hh:mm tt")
            ));
            // Alerts
            eventQueue.Enqueue(new EventsData(
                name: "Severe Weather Warning",
                category: "Alerts",
                description: "Heavy rains and strong winds expected tomorrow.",
                time: DateTime.Now.AddDays(0),
                media: Image.FromFile(@"Pictures\Weather.jpg"),
                location: "Cape Town",
                formattedTime: DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")
            ));
            eventQueue.Enqueue(new EventsData(
                name: "Water Supply Interruption Notice",
                category: "Alerts",
                description: "Water supply will be interrupted for maintenance.",
                time: DateTime.Now.AddDays(3),
                media: Image.FromFile(@"Pictures\Water.jpg"),
                location: "Suburban Areas in Gauteng",
                formattedTime: DateTime.Now.AddDays(3).ToString("dd/MM/yyyy hh:mm tt")
            ));

            // After each event, add the category to the HashSet
            foreach (var eventItem in eventQueue)
            {
                uniqueCategories.Add(eventItem.Category);
            }
        }

        /// <summary>
        /// method to display categories in the search combo box.
        /// </summary>
        private void DisplayCategories()
        {
            categorySearchComboBox.Items.Clear();
            foreach (var category in uniqueCategories)
            {
                categorySearchComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// method to show recommendations based on the most searched categories.
        /// </summary>
        /// <summary>
        private void ShowRecommendations()
        {
            if (!searchCounts.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var topCategories = searchCounts
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => kvp.Key)
                .ToList();

            List<EventsData> recommendedEvents = GetRecommendedEvents(topCategories);

            if (!recommendedEvents.Any())
            {
                MessageBox.Show("No recommended events found based on your searches.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var recommendationsMessage = new StringBuilder();
            recommendationsMessage.AppendLine("Here are some recommended events based on your searches:");

            foreach (var recommendedEvent in recommendedEvents)
            {
                recommendationsMessage.AppendLine($"- {recommendedEvent.Name} at {recommendedEvent.Location} on {recommendedEvent.FormattedTime}");
            }

            MessageBox.Show(recommendationsMessage.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// method to get recommended events based on searched categories.
        /// </summary>
        /// <param name="topCategories">List of top searched categories.</param>
        /// <returns>List of recommended events.</returns>
        private List<EventsData> GetRecommendedEvents(List<string> topCategories)
        {

            var lowerTopCategories = topCategories.Select(c => c.ToLower()).ToList();

            var recommendedEvents = eventQueue
                .Where(e => lowerTopCategories.Contains(e.Category.ToLower()))
                .ToList();

            return recommendedEvents;
        }

        /// <summary>
        /// method used to filter based on category of event/announcement.
        /// </summary>
        /// <summary>
        private void FilterCategory()
        {
            string categoryInput = categorySearchComboBox.SelectedItem?.ToString();
            DateTime selectedDate = dateFilter.Value.Date;

            if (string.IsNullOrEmpty(categoryInput) || selectedDate == DateTime.MinValue)
            {
                MessageBox.Show("Please select a category and date to filter the events.", "Filter Events", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string categoryInputLower = categoryInput?.ToLower();

            if (!string.IsNullOrEmpty(categoryInputLower))
            {
                if (searchCounts.ContainsKey(categoryInputLower))
                {
                    searchCounts[categoryInputLower]++;
                }
                else
                {
                    searchCounts[categoryInputLower] = 1;
                }
            }

            var filteredEvents = eventQueue
                .Where(e =>
                    (string.IsNullOrEmpty(categoryInputLower) || e.Category.ToLower() == categoryInputLower) &&
                    (selectedDate == DateTime.MinValue || e.Time.Date == selectedDate))
                .ToList();

            if (!filteredEvents.Any())
            {
                MessageBox.Show("No events found matching the selected category and date.", "Filter Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (var eventItem in filteredEvents)
            {
                EventUserControl eventControl = new EventUserControl
                {
                    EventName = eventItem.Name,
                    EventCategory = eventItem.Category,
                    EventDescription = eventItem.Description,
                    EventLocation = eventItem.Location,
                    EventTime = eventItem.Time,
                    EventImage = eventItem.Media
                };
                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }


        /// <summary>
        /// method to display the filtered results.
        /// </summary>
        /// <param name="filteredEvents">List of filtered events to display.</param>
        private void DisplayFilteredEvents(List<EventsData> filteredEvents)
        {

            flowLayoutPanel1.Controls.Clear();

            if (filteredEvents.Count == 0)
            {
                MessageBox.Show("No events found for the selected category.", "No Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add each filtered event to the flowLayoutPanel
            foreach (var eventItem in filteredEvents)
            {
                EventUserControl eventControl = new EventUserControl
                {
                    EventName = eventItem.Name,
                    EventCategory = eventItem.Category,
                    EventDescription = eventItem.Description,
                    EventLocation = eventItem.Location,
                    EventTime = eventItem.Time,
                    EventImage = eventItem.Media
                };

                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }

        /// <summary>
        /// Button user clicks to view recommendations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recommendationBtn_Click(object sender, EventArgs e)
        {
            ShowRecommendations();
        }

        /// <summary>
        /// method calling filter category when user clicks search button .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddToSearchHistory(searchTerm);

            if (searchCounts.ContainsKey(searchTerm))
            {
                searchCounts[searchTerm]++;
            }
            else
            {
                searchCounts[searchTerm] = 1;
            }

            var filteredEvents = eventQueue.Where(eventItem =>
                eventItem.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                eventItem.Category.Equals(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (filteredEvents.Count > 0)
            {
                DisplayFilteredEvents(filteredEvents);
            }
            else
            {
                MessageBox.Show("No events found matching the search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FilterCategory();
        }

        /// <summary>
        /// method used to reset the search filters.
        /// </summary>
        private void ResetFilters()
        {
            categorySearchComboBox.SelectedIndex = -1;
            dateFilter.Value = DateTime.Now;
            DisplayEvents();
        }

        /// <summary>
        /// Adds a search term to the stack.
        /// </summary>
        /// <param name="searchTerm">The search term to add.</param>
        private void AddToSearchHistory(string searchTerm)
        {
            searchHistoryStack.Push(searchTerm);
        }

        /// <summary>
        /// Displays the last search term from the stack.
        /// </summary>
        private void ViewSearchHistory()
        {
            if (searchHistoryStack.Count == 0)
            {
                MessageBox.Show("Search history is empty.", "Search History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lastSearch = searchHistoryStack.Peek();
            MessageBox.Show($"Last search term: {lastSearch}", "Search History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// calling method that displays search history.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchHistoryBtn_Click(object sender, EventArgs e)
        {
            ViewSearchHistory();
        }

        /// <summary>
        /// Clears the search history stack.
        /// </summary>
        private void ClearSearchHistory()
        {
            searchHistoryStack.Clear();
            searchTxtBox.Clear();
            MessageBox.Show("Search history cleared.", "Clear History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// calling the method used to reset the search filters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFilters();
            ClearSearchHistory();
        }


        /// <summary>
        /// Button user clicks to go back to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back?",
                "Confirm Back",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void categorySearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void eventsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
