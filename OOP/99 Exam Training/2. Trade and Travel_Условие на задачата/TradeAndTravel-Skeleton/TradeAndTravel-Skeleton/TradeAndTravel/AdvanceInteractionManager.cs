using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvanceInteractionManager : InteractionManager
    {
        public AdvanceInteractionManager()
            : base()
        {
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;

                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string craftedItemType, string craftedItemName )
        {
            switch (craftedItemType)
            {
                case "armor":
                   this.CragtArmor(actor, craftedItemName);
                    break;

                case "weapon":
                    this.CraftWeapon(actor, craftedItemName);
                    break;
                default:
                    break;
            }
        }

        private void CraftWeapon(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if (actorInventory.Any((item) => item.ItemType == ItemType.Iron) &&
                actorInventory.Any((item) => item.ItemType == ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(craftedItemName));
            };
        }

        private void CragtArmor(Person actor, string craftedItemName)
        {
            var actorInventory = actor.ListInventory();
            if (actorInventory.Any((item) => item.ItemType == ItemType.Iron))
            {
                this.AddToPerson(actor, new Armor(craftedItemName));
            }
        }

        private void HandleGatherInteraction(Person actor, string producedItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                var actorInventory = actor.ListInventory();
                foreach (var item in actorInventory)
                {
                    var producedItem = gatheringLocation.ProduceItem(producedItemName);
                    this.AddToPerson(actor, producedItem);
                    break;

                }
                
            }

        }
    }
}
