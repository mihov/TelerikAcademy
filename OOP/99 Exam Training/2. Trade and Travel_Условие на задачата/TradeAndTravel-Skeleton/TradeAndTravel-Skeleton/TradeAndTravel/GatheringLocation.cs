using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        public GatheringLocation(string name, LocationType locationType, ItemType gatheredType, ItemType requiredItem)
            : base(name, locationType)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredItem;
        }

        public ItemType GatheredType
        {
            get;
            protected set;
        }

        public ItemType RequiredItem
        {
            get;
            protected set;
        }

        public abstract Item ProduceItem(string produceItem);
    }
}
