using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.ArtifactComparer.Controller;
using Gameplay.ArtifactComparer.Model;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Chest;
using Gameplay.Isles.Clan;
using Gameplay.Isles.Clan.Events;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Inventory
{
	// Token: 0x020011BF RID: 4543
	[Token(Token = "0x20011BF")]
	public class GolemInventoryManager : IGameManager, IBaseManager, IInventoryManager
	{
		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06006C04 RID: 27652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001610")]
		public string Name
		{
			[Token(Token = "0x6006C04")]
			[Address(RVA = "0xB6F3", Offset = "0xB6F3", VA = "0xB6F3", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002C3 RID: 707
		// (add) Token: 0x06006C05 RID: 27653 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C06 RID: 27654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C3")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C05")]
			[Address(RVA = "0xB6F4", Offset = "0xB6F4", VA = "0xB6F4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C06")]
			[Address(RVA = "0xB6F5", Offset = "0xB6F5", VA = "0xB6F5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C4 RID: 708
		// (add) Token: 0x06006C07 RID: 27655 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C08 RID: 27656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C4")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C07")]
			[Address(RVA = "0xB6F6", Offset = "0xB6F6", VA = "0xB6F6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C08")]
			[Address(RVA = "0xB6F7", Offset = "0xB6F7", VA = "0xB6F7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06006C09 RID: 27657 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C0A RID: 27658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001611")]
		public GolemInventoryModel Model
		{
			[Token(Token = "0x6006C09")]
			[Address(RVA = "0xB6F8", Offset = "0xB6F8", VA = "0xB6F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C0A")]
			[Address(RVA = "0xB6F9", Offset = "0xB6F9", VA = "0xB6F9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C0C RID: 27660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001612")]
		public GolemInventoryController Controller
		{
			[Token(Token = "0x6006C0B")]
			[Address(RVA = "0xB6FA", Offset = "0xB6FA", VA = "0xB6FA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C0C")]
			[Address(RVA = "0xB6FB", Offset = "0xB6FB", VA = "0xB6FB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001613")]
		public GolemInventoryEvents Events
		{
			[Token(Token = "0x6006C0D")]
			[Address(RVA = "0xB6FC", Offset = "0xB6FC", VA = "0xB6FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06006C0E RID: 27662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001614")]
		private InventoryBaseModel Model
		{
			[Token(Token = "0x6006C0E")]
			[Address(RVA = "0xB6FD", Offset = "0xB6FD", VA = "0xB6FD", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001615")]
		private InventoryBaseEvents Events
		{
			[Token(Token = "0x6006C0F")]
			[Address(RVA = "0xB6FE", Offset = "0xB6FE", VA = "0xB6FE", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C10")]
		[Address(RVA = "0xB6FF", Offset = "0xB6FF", VA = "0xB6FF")]
		public GolemInventoryManager(IGame game)
		{
		}

		// Token: 0x17001616 RID: 5654
		// (set) Token: 0x06006C11 RID: 27665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001616")]
		private ClanIsle ClanIsle
		{
			[Token(Token = "0x6006C11")]
			[Address(RVA = "0xB700", Offset = "0xB700", VA = "0xB700")]
			set
			{
			}
		}

		// Token: 0x17001617 RID: 5655
		// (set) Token: 0x06006C12 RID: 27666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001617")]
		private ClanIsleEvents ClanIsleEvents
		{
			[Token(Token = "0x6006C12")]
			[Address(RVA = "0xB701", Offset = "0xB701", VA = "0xB701")]
			set
			{
			}
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C13")]
		[Address(RVA = "0xB702", Offset = "0xB702", VA = "0xB702")]
		private void BuildingStateChangedEventHandler(uint type)
		{
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C14")]
		[Address(RVA = "0xB703", Offset = "0xB703", VA = "0xB703")]
		private void HandleGolemCreated()
		{
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C15")]
		[Address(RVA = "0xB704", Offset = "0xB704", VA = "0xB704")]
		private void UserClanStatusChangedEventHandler()
		{
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C16")]
		[Address(RVA = "0xB705", Offset = "0xB705", VA = "0xB705")]
		private void LocationChangedEventHandler(ulong isleId)
		{
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C17")]
		[Address(RVA = "0xB706", Offset = "0xB706", VA = "0xB706")]
		private void ControllerInitEventHandler()
		{
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C18")]
		[Address(RVA = "0xB707", Offset = "0xB707", VA = "0xB707", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C19")]
		[Address(RVA = "0xB708", Offset = "0xB708", VA = "0xB708", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1A")]
		[Address(RVA = "0xB709", Offset = "0xB709", VA = "0xB709")]
		public void ShowChestWindow([Optional] ArtikulMenuActionDic.Types.Actions[] customActions, [Optional] ArtikulMenuActionDic.Types.Actions[] closeWindowActions, [Optional] InventoryChestWindowOptions.ArtifactFilterDelegate customFilterFunction)
		{
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1B")]
		[Address(RVA = "0xB70A", Offset = "0xB70A", VA = "0xB70A")]
		public void ShowArtifactComparerWindow(ArtifactData artifactData)
		{
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0xB70B", Offset = "0xB70B", VA = "0xB70B")]
		public void SellItem(ArtifactData artifactData)
		{
		}

		// Token: 0x040038E5 RID: 14565
		[Token(Token = "0x40038E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly IGame _game;

		// Token: 0x040038E6 RID: 14566
		[Token(Token = "0x40038E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ArtifactComparerModel _comparerModel;

		// Token: 0x040038E7 RID: 14567
		[Token(Token = "0x40038E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ArtifactComparerController _comparerController;

		// Token: 0x040038E8 RID: 14568
		[Token(Token = "0x40038E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArtifactComparerEvents _comparerEvents;

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ClanIsleEvents _clanIsleEvents;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ClanIsle _clanIsle;

		// Token: 0x040038EB RID: 14571
		[Token(Token = "0x40038EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _isInit;
	}
}
