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
        // Queue to store all event data objects
        private Queue<EventsData> eventQueue = new Queue<EventsData>();
        // Dictionary to count how many times each search term is used
        private Dictionary<string, int> searchCounts = new Dictionary<string, int>();
        // Sorted dictionary to organize events by date
        private SortedDictionary<DateTime, Queue<EventsData>> eventDictionary = new SortedDictionary<DateTime, Queue<EventsData>>();
        // HashSet to store unique event categories
        private HashSet<string> uniqueCategories = new HashSet<string>();
        // Stack to keep track of search history
        private Stack<string> searchHistoryStack = new Stack<string>();

        // Constructor that initializes the form and loads sample data
        public AddEventForm()
        {
            InitializeComponent();
            SampleEvents();
            DisplayCategories();
            DisplayEvents();
        }

        /// <summary>
        /// Displays all events in the flowLayoutPanel, grouped by date
        /// </summary> 
        private void DisplayEvents()
        {
            eventDictionary.Clear();

            // Group events by their date
            foreach (var eventItem in eventQueue)
            {
                if (!eventDictionary.ContainsKey(eventItem.Time))
                {
                    eventDictionary[eventItem.Time] = new Queue<EventsData>();
                }
                eventDictionary[eventItem.Time].Enqueue(eventItem);
            }


            // Show a message if there are no events
            if (eventDictionary.Count == 0)
            {
                MessageBox.Show("No events to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            flowLayoutPanel1.Controls.Clear();

            // Add each event as a user control to the panel
            foreach (var kvp in eventDictionary)
            {
                foreach (var eventItem in kvp.Value)
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
        }

        /// <summary>
        /// Adds a set of sample events to the queue and collects unique categories
        /// </summary>
        private void SampleEvents()
        {
            // Add various sample events
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

            eventQueue.Enqueue(new EventsData(
                name: "Voter Registration Drive",
                category: "Government Service",
                description: "Get registered to vote in upcoming elections.",
                time: DateTime.Now.AddDays(-7),
                media: Image.FromFile(@"Pictures\Voting.jpg"),
                location: "City Hall",
                formattedTime: DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy hh:mm tt")
            ));
 
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

            // Collect all unique categories from the events
            foreach (var eventItem in eventQueue)
            {
                uniqueCategories.Add(eventItem.Category);
            }
        }

        /// <summary>
        /// Populates the category combo box with all unique categories
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
        /// Shows recommended events in the same category, excluding already shown events
        /// </summary>
        private void ShowRecommendations(List<EventsData> alreadyShown = null)
        {
            string lastCategory = categorySearchComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(lastCategory))
            {
                MessageBox.Show("No category selected for recommendations.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Find recommended events in the same category
            var recommendedEvents = eventQueue
                .Where(e => e.Category.Equals(lastCategory, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Exclude events already shown in the main results
            if (alreadyShown != null)
            {
                recommendedEvents = recommendedEvents
                    .Where(e => !alreadyShown.Any(a => a.Name == e.Name && a.Time == e.Time))
                    .ToList();
            }

            if (!recommendedEvents.Any())
            {
                MessageBox.Show("No additional recommended events found for this category.", "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Build and show the recommendations message
            var recommendationsMessage = new StringBuilder();
            recommendationsMessage.AppendLine("Here are some additional recommended events in this category:");

            foreach (var recommendedEvent in recommendedEvents)
            {
                recommendationsMessage.AppendLine($"- {recommendedEvent.Name} at {recommendedEvent.Location} on {recommendedEvent.FormattedTime}");
            }

            MessageBox.Show(recommendationsMessage.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Displays a filtered list of events in the flowLayoutPanel
        private void DisplayFilteredEvents(List<EventsData> filteredEvents)
        {

            flowLayoutPanel1.Controls.Clear();

            if (filteredEvents.Count == 0)
            {
                MessageBox.Show("No events found for the selected category.", "No Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        /// Event handler for the recommendations button
        /// </summary>
        private void recommendationBtn_Click(object sender, EventArgs e)
        {
            ShowRecommendations();
        }

        /// <summary>
        /// Handles the search button click: filters events by search term, category, and date
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text.Trim();
            string categoryInput = categorySearchComboBox.SelectedItem?.ToString();
            DateTime selectedDate = dateFilter.Value.Date;

            if (string.IsNullOrEmpty(searchTerm) && string.IsNullOrEmpty(categoryInput))
            {
                MessageBox.Show("Please enter a search term or select a category.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddToSearchHistory(searchTerm);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (searchCounts.ContainsKey(searchTerm))
                    searchCounts[searchTerm]++;
                else
                    searchCounts[searchTerm] = 1;
            }

            // Filter events by search term, category, and date
            var filteredEvents = eventQueue.Where(eventItem =>
                (string.IsNullOrEmpty(searchTerm) ||
                    eventItem.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    eventItem.Category.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(categoryInput) || eventItem.Category.Equals(categoryInput, StringComparison.OrdinalIgnoreCase)) &&
                (selectedDate == DateTime.MinValue || eventItem.Time.Date == selectedDate)
            ).ToList();

            if (filteredEvents.Count > 0)
            {
                DisplayFilteredEvents(filteredEvents);
            }
            else
            {
                MessageBox.Show("No events found matching your search and filter criteria.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flowLayoutPanel1.Controls.Clear();
            }
        }

        /// <summary>
        /// Resets all filters and displays all events
        /// </summary>
        private void ResetFilters()
        {
            categorySearchComboBox.SelectedIndex = -1;
            dateFilter.Value = DateTime.Now;
            DisplayEvents();
        }

        /// <summary>
        /// Adds a search term to the search history stack
        /// </summary>
        private void AddToSearchHistory(string searchTerm)
        {
            searchHistoryStack.Push(searchTerm);
        }

        /// <summary>
        /// Shows the last search term from the search history
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
        /// Event handler for the search history button
        /// </summary>
        private void searchHistoryBtn_Click(object sender, EventArgs e)
        {
            ViewSearchHistory();
        }

        /// <summary>
        /// Clears the search history and search box
        /// </summary>
        private void ClearSearchHistory()
        {
            searchHistoryStack.Clear();
            searchTxtBox.Clear();
            MessageBox.Show("Search history cleared.", "Clear History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Event handler for the reset button: resets filters and clears search history
        /// </summary>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFilters();
            ClearSearchHistory();
        }

        /// <summary>
        /// Event handler for the back button: confirms and closes the form
        /// </summary>
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
