using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Collections.Controller;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.Model.Factories;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200115E RID: 4446
	[Token(Token = "0x200115E")]
	public class CollectionsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001565")]
		public string Name
		{
			[Token(Token = "0x6006897")]
			[Address(RVA = "0xB3C1", Offset = "0xB3C1", VA = "0xB3C1", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006898")]
		[Address(RVA = "0xB3C2", Offset = "0xB3C2", VA = "0xB3C2")]
		public CollectionsManager(IGame game)
		{
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001566")]
		public IGame Game
		{
			[Token(Token = "0x6006899")]
			[Address(RVA = "0xB3C3", Offset = "0xB3C3", VA = "0xB3C3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600689A")]
			[Address(RVA = "0xB3C4", Offset = "0xB3C4", VA = "0xB3C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000275 RID: 629
		// (add) Token: 0x0600689B RID: 26779 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600689C RID: 26780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000275")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600689B")]
			[Address(RVA = "0xB3C5", Offset = "0xB3C5", VA = "0xB3C5", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600689C")]
			[Address(RVA = "0xB3C6", Offset = "0xB3C6", VA = "0xB3C6", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000276 RID: 630
		// (add) Token: 0x0600689D RID: 26781 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600689E RID: 26782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000276")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600689D")]
			[Address(RVA = "0xB3C7", Offset = "0xB3C7", VA = "0xB3C7", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600689E")]
			[Address(RVA = "0xB3C8", Offset = "0xB3C8", VA = "0xB3C8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001567")]
		public CollectionsModel Model
		{
			[Token(Token = "0x600689F")]
			[Address(RVA = "0xB3C9", Offset = "0xB3C9", VA = "0xB3C9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068A0")]
			[Address(RVA = "0xB3CA", Offset = "0xB3CA", VA = "0xB3CA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001568")]
		public CollectionsEvents Events
		{
			[Token(Token = "0x60068A1")]
			[Address(RVA = "0xB3CB", Offset = "0xB3CB", VA = "0xB3CB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068A2")]
			[Address(RVA = "0xB3CC", Offset = "0xB3CC", VA = "0xB3CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068A4 RID: 26788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001569")]
		public CollectionsController Controller
		{
			[Token(Token = "0x60068A3")]
			[Address(RVA = "0xB3CD", Offset = "0xB3CD", VA = "0xB3CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068A4")]
			[Address(RVA = "0xB3CE", Offset = "0xB3CE", VA = "0xB3CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700156A")]
		public ICollectionsMaterialsStorage MaterialsStorage
		{
			[Token(Token = "0x60068A5")]
			[Address(RVA = "0xB3CF", Offset = "0xB3CF", VA = "0xB3CF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068A6")]
			[Address(RVA = "0xB3D0", Offset = "0xB3D0", VA = "0xB3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0xB3D1", Offset = "0xB3D1", VA = "0xB3D1", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A8")]
		[Address(RVA = "0xB3D2", Offset = "0xB3D2", VA = "0xB3D2", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0xB3D3", Offset = "0xB3D3", VA = "0xB3D3")]
		private void InitEventHandler()
		{
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0xB3D4", Offset = "0xB3D4", VA = "0xB3D4")]
		public void ShowOwnCollectionsWindow()
		{
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AB")]
		[Address(RVA = "0xB3D5", Offset = "0xB3D5", VA = "0xB3D5")]
		public void ShowOwnCollectionsWindow(Predicate<CollectionData> customFilter)
		{
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AC")]
		[Address(RVA = "0xB3D6", Offset = "0xB3D6", VA = "0xB3D6")]
		public void ShowCollectionsWindow(UserData user)
		{
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0xB3D7", Offset = "0xB3D7", VA = "0xB3D7")]
		public void ShowCollectionInfoWindow(uint collectionId, uint rank)
		{
		}

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x24")]
		private ICollectionDataFactory _collectionDataFactory;
	}
}
