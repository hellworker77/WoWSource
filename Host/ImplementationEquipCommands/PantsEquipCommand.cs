using System.Linq;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;

namespace Host.ImplementationEquipCommands;

public class PantsEquipCommand : AbstractEquipCommand
{
    public PantsEquipCommand(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }
    protected override string CommandString => "Pants";
    protected override void InternalLogic()
    {
        var item = _viewModel.SelectedPlayer.Bag?.SelectedItem;
        if (item.Type == ItemType.None)
        {
            return;
        }

        var itemInBag = _viewModel.SelectedPlayer.Bag.Items.FirstOrDefault(i => i.Name == item.Name);


        var savedItem = _viewModel.SelectedPlayer.Inventory.Pants;
        _viewModel.SelectedPlayer.Inventory.Pants = new ItemDto();
        _viewModel.SelectedPlayer.Inventory.Pants.SetSourceValue(item);
        itemInBag.SetSourceValue(savedItem);

        base.InternalLogic();
    }
}