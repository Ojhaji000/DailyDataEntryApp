using DailyDataEntryApp.Core;

namespace DailyDataEntryApp;

public partial class DataEntryPage : ContentPage
{
    public string SelectedDepositReason { get; set; }

    public DataEntryPage()
	{
		InitializeComponent();
        DepositReasonPicker.ItemsSource = new List<string>
            {
                "Mutual Fund",
                "RD",
                "Insurance",
                "Miscellaneous"
            };
    }
    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        if (DepositReasonPicker.SelectedIndex != -1) // Ensure an item is selected
        {
            SelectedDepositReason = DepositReasonPicker.SelectedItem.ToString();
        }
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    private void SubmitBtn_Clicked(object sender, EventArgs e)
    {
        string name = DepositorName.Text;
        string reason = SelectedDepositReason;
        float amount = (float)Convert.ToDouble(DepositedAmount.Text);
        DateTime date = DepositDate.Date;
        DataManager.MakeDataEntry(name, reason, amount, date);
    }
}