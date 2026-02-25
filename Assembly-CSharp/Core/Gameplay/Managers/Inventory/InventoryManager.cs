using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.ArtifactComparer.Controller;
using Gameplay.ArtifactComparer.Model;
using Gameplay.Inventory.Controller;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Chest;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Dic;
using Utils;

namespace Core.Gameplay.Managers.Inventory
{
	// Token: 0x020011C1 RID: 4545
	[Token(Token = "0x20011C1")]
	public class InventoryManager : IGameManager, IBaseManager, IInventoryManager
	{
		// Token: 0x140002C5 RID: 709
		// (add) Token: 0x06006C20 RID: 27680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C21 RID: 27681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C5")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C20")]
			[Address(RVA = "0xB70D", Offset = "0xB70D", VA = "0xB70D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C21")]
			[Address(RVA = "0xB70E", Offset = "0xB70E", VA = "0xB70E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C6 RID: 710
		// (add) Token: 0x06006C22 RID: 27682 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C23 RID: 27683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C6")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C22")]
			[Address(RVA = "0xB70F", Offset = "0xB70F", VA = "0xB70F", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C23")]
			[Address(RVA = "0xB710", Offset = "0xB710", VA = "0xB710", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C25 RID: 27685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700161A")]
		public InventoryModel Model
		{
			[Token(Token = "0x6006C24")]
			[Address(RVA = "0xB711", Offset = "0xB711", VA = "0xB711")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C25")]
			[Address(RVA = "0xB712", Offset = "0xB712", VA = "0xB712")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06006C26 RID: 27686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C27 RID: 27687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700161B")]
		public InventoryController Controller
		{
			[Token(Token = "0x6006C26")]
			[Address(RVA = "0xB713", Offset = "0xB713", VA = "0xB713")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C27")]
			[Address(RVA = "0xB714", Offset = "0xB714", VA = "0xB714")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06006C28 RID: 27688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700161C")]
		private InventoryBaseModel Model
		{
			[Token(Token = "0x6006C28")]
			[Address(RVA = "0xB715", Offset = "0xB715", VA = "0xB715", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700161D")]
		private InventoryBaseEvents Events
		{
			[Token(Token = "0x6006C29")]
			[Address(RVA = "0xB716", Offset = "0xB716", VA = "0xB716", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06006C2A RID: 27690 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C2B RID: 27691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700161E")]
		public ArtifactComparerController ComparerController
		{
			[Token(Token = "0x6006C2A")]
			[Address(RVA = "0xB717", Offset = "0xB717", VA = "0xB717")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C2B")]
			[Address(RVA = "0xB718", Offset = "0xB718", VA = "0xB718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06006C2C RID: 27692 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C2D RID: 27693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700161F")]
		public ArtifactComparerModel ComparerModel
		{
			[Token(Token = "0x6006C2C")]
			[Address(RVA = "0xB719", Offset = "0xB719", VA = "0xB719")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C2D")]
			[Address(RVA = "0xB71A", Offset = "0xB71A", VA = "0xB71A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06006C2E RID: 27694 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C2F RID: 27695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001620")]
		public InventoryEvents Events
		{
			[Token(Token = "0x6006C2E")]
			[Address(RVA = "0xB71B", Offset = "0xB71B", VA = "0xB71B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C2F")]
			[Address(RVA = "0xB71C", Offset = "0xB71C", VA = "0xB71C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06006C30 RID: 27696 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C31 RID: 27697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001621")]
		public ArtifactComparerEvents ComparerEvents
		{
			[Token(Token = "0x6006C30")]
			[Address(RVA = "0xB71D", Offset = "0xB71D", VA = "0xB71D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C31")]
			[Address(RVA = "0xB71E", Offset = "0xB71E", VA = "0xB71E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C32")]
		[Address(RVA = "0xB71F", Offset = "0xB71F", VA = "0xB71F")]
		public InventoryManager(IGame game)
		{
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C33")]
		[Address(RVA = "0xB720", Offset = "0xB720", VA = "0xB720", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C34")]
		[Address(RVA = "0xB721", Offset = "0xB721", VA = "0xB721")]
		private void ControllerInitEvent()
		{
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C35")]
		[Address(RVA = "0xB722", Offset = "0xB722", VA = "0xB722", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06006C36 RID: 27702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001622")]
		public string Name
		{
			[Token(Token = "0x6006C36")]
			[Address(RVA = "0xB723", Offset = "0xB723", VA = "0xB723", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C37")]
		[Address(RVA = "0xB724", Offset = "0xB724", VA = "0xB724")]
		public OpToken<IMessage, object> BuySlots(uint quantity)
		{
			return null;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0xB725", Offset = "0xB725", VA = "0xB725")]
		public void SellItem(ArtifactData artifactData)
		{
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C39")]
		[Address(RVA = "0xB726", Offset = "0xB726", VA = "0xB726")]
		public void MoveItemToBag(ArtifactData artifactData)
		{
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0xB727", Offset = "0xB727", VA = "0xB727")]
		public void MoveItemToChest(ArtifactData artifactData)
		{
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3B")]
		[Address(RVA = "0xB728", Offset = "0xB728", VA = "0xB728")]
		public void UnEquip(ArtifactData artifact)
		{
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3C")]
		[Address(RVA = "0xB729", Offset = "0xB729", VA = "0xB729")]
		public void Equip(ArtifactData artifact)
		{
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3D")]
		[Address(RVA = "0xB72A", Offset = "0xB72A", VA = "0xB72A")]
		public void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholestack = false)
		{
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0xB72B", Offset = "0xB72B", VA = "0xB72B")]
		public void ShowChestWindow(ArtikulMenuActionDic.Types.Actions[] customActions, ArtikulMenuActionDic.Types.Actions[] closeWindowActions, InventoryChestWindowOptions.ArtifactFilterDelegate customFilterFunction)
		{
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0xB72C", Offset = "0xB72C", VA = "0xB72C")]
		public void ShowChestWindow()
		{
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C40")]
		[Address(RVA = "0xB72D", Offset = "0xB72D", VA = "0xB72D")]
		public void ShowArtifactComparerWindow(ArtifactData artifactData)
		{
		}

		// Token: 0x040038F4 RID: 14580
		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x28")]
		private readonly IGame _game;
	}
}
