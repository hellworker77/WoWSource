using System.Linq;
using System.Windows.Media.Animation;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;

namespace Host.ImplementationEquipCommands;

public class RingEquipCommand : AbstractEquipCommand
{
    public RingEquipCommand(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }
    protected override string CommandString => "Ring";
    protected override void InternalLogic()
    {
        var item = _viewModel.SelectedPlayer.Bag?.SelectedItem;
        if (item.Type == ItemType.None)
        {
            return;
        }

        var itemInBag = _viewModel.SelectedPlayer.Bag.Items.FirstOrDefault(i => i.Name == item.Name);


        var ringOne = _viewModel.SelectedPlayer.Inventory.RingLeft;
        var ringTwo = _viewModel.SelectedPlayer.Inventory.RingRight;

        var powerOne = ringOne?.GetArmor() ?? +ringOne?.GetHealth() ?? +ringOne?.GetDamage()?? 0;
        var powerTwo = ringTwo?.GetArmor() ?? +ringTwo?.GetHealth() ?? +ringOne?.GetDamage()?? 0;
        ItemDto? savedItem;
        if (powerTwo > powerOne)
        {
            savedItem = _viewModel.SelectedPlayer.Inventory.RingLeft;
            _viewModel.SelectedPlayer.Inventory.RingLeft = new ItemDto();
            _viewModel.SelectedPlayer.Inventory.RingLeft.SetSourceValue(item);
        }
        else
        {
            savedItem = _viewModel.SelectedPlayer.Inventory.RingRight;
            _viewModel.SelectedPlayer.Inventory.RingRight = new ItemDto();
            _viewModel.SelectedPlayer.Inventory.RingRight.SetSourceValue(item);
        }



        itemInBag.SetSourceValue(savedItem);

        base.InternalLogic();
    }
}