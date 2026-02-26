using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Application;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Audio;
using Core.Gameplay.Managers.Billing;
using Core.Gameplay.Managers.EndlessPaymentOptionsList;
using Core.Gameplay.Managers.GameActivityRouting;
using Core.Gameplay.Managers.GdEvents;
using Core.Gameplay.Managers.Inventory;
using Core.Gameplay.Managers.Location;
using Core.Gameplay.Managers.Notifications;
using Core.Gameplay.Managers.Prefetch;
using Core.Gameplay.Managers.Requirements;
using Core.Gameplay.Managers.Skins;
using Core.Gameplay.Managers.Tutorial;
using Core.Gameplay.Managers.Tutorial.Guide;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001116 RID: 4374
	[Token(Token = "0x2001116")]
	public abstract class AbstractGame : IGame
	{
		// Token: 0x14000246 RID: 582
		// (add) Token: 0x060065FD RID: 26109 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060065FE RID: 26110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000246")]
		public event Action<IGame> InitCompleteEvent
		{
			[Token(Token = "0x60065FD")]
			[Address(RVA = "0xB182", Offset = "0xB182", VA = "0xB182", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60065FE")]
			[Address(RVA = "0xB183", Offset = "0xB183", VA = "0xB183", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000247 RID: 583
		// (add) Token: 0x060065FF RID: 26111 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006600 RID: 26112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000247")]
		public event Action<IGame> DeinitCompleteEvent
		{
			[Token(Token = "0x60065FF")]
			[Address(RVA = "0xB184", Offset = "0xB184", VA = "0xB184", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006600")]
			[Address(RVA = "0xB185", Offset = "0xB185", VA = "0xB185", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A3")]
		public IApp Application
		{
			[Token(Token = "0x6006601")]
			[Address(RVA = "0xB186", Offset = "0xB186", VA = "0xB186", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006602")]
			[Address(RVA = "0xB187", Offset = "0xB187", VA = "0xB187")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x00013710 File Offset: 0x00011910
		// (set) Token: 0x06006604 RID: 26116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A4")]
		public bool IsInit
		{
			[Token(Token = "0x6006603")]
			[Address(RVA = "0xB188", Offset = "0xB188", VA = "0xB188", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006604")]
			[Address(RVA = "0xB189", Offset = "0xB189", VA = "0xB189")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06006605 RID: 26117 RVA: 0x00013728 File Offset: 0x00011928
		// (set) Token: 0x06006606 RID: 26118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A5")]
		public bool IsDeInitProcess
		{
			[Token(Token = "0x6006605")]
			[Address(RVA = "0xB18A", Offset = "0xB18A", VA = "0xB18A", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006606")]
			[Address(RVA = "0xB18B", Offset = "0xB18B", VA = "0xB18B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006607")]
		[Address(RVA = "0xB18C", Offset = "0xB18C", VA = "0xB18C", Slot = "11")]
		public void Init(IApp application)
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_AbstractGame__Init(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a8fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Count__);
		    DAT_ram_00a5a8fc = '\x01';
		  }
		  if (*(char *)(param1 + 0x15) == '\0') {
		    *(undefined1 *)(param1 + 0x15) = 1;
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x20),0);
		    if (*(int *)(param1 + 0x1c) == *(int *)(*(int *)(param1 + 0x18) + 0xc)) {
		      *(int *)(param1 + 0x1c) = *(int *)(param1 + 0x1c) + -1;
		    }
		    Core_Gameplay_AbstractGame__HandleInitManagersQueue(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006608")]
		[Address(RVA = "0xB18D", Offset = "0xB18D", VA = "0xB18D", Slot = "12")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_AbstractGame__Deinit(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  param1_00 = *(int *)(param1 + 0x18);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006609")]
		[Address(RVA = "0xB18E", Offset = "0xB18E", VA = "0xB18E")]
		protected void Add(IGameManager value)
		{
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600660B RID: 26123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A6")]
		public WorldManager WorldManager
		{
			[Token(Token = "0x600660A")]
			[Address(RVA = "0xB18F", Offset = "0xB18F", VA = "0xB18F", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600660B")]
			[Address(RVA = "0xB190", Offset = "0xB190", VA = "0xB190")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600660D RID: 26125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A7")]
		public LocationManager LocationManager
		{
			[Token(Token = "0x600660C")]
			[Address(RVA = "0xB191", Offset = "0xB191", VA = "0xB191", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600660D")]
			[Address(RVA = "0xB192", Offset = "0xB192", VA = "0xB192")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600660E RID: 26126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600660F RID: 26127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A8")]
		public InventoryManager InventoryManager
		{
			[Token(Token = "0x600660E")]
			[Address(RVA = "0xB193", Offset = "0xB193", VA = "0xB193", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600660F")]
			[Address(RVA = "0xB194", Offset = "0xB194", VA = "0xB194")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06006610 RID: 26128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006611 RID: 26129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A9")]
		public MedalsManager MedalsManager
		{
			[Token(Token = "0x6006610")]
			[Address(RVA = "0xB195", Offset = "0xB195", VA = "0xB195", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006611")]
			[Address(RVA = "0xB196", Offset = "0xB196", VA = "0xB196")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006613 RID: 26131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AA")]
		public AprsManager AprsManager
		{
			[Token(Token = "0x6006612")]
			[Address(RVA = "0xB197", Offset = "0xB197", VA = "0xB197", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006613")]
			[Address(RVA = "0xB198", Offset = "0xB198", VA = "0xB198")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06006614 RID: 26132 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006615 RID: 26133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AB")]
		public UserManager UserManager
		{
			[Token(Token = "0x6006614")]
			[Address(RVA = "0xB199", Offset = "0xB199", VA = "0xB199", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006615")]
			[Address(RVA = "0xB19A", Offset = "0xB19A", VA = "0xB19A")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AC")]
		public InitCompleteManager InitCompleteManager
		{
			[Token(Token = "0x6006616")]
			[Address(RVA = "0xB19B", Offset = "0xB19B", VA = "0xB19B", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006617")]
			[Address(RVA = "0xB19C", Offset = "0xB19C", VA = "0xB19C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AD")]
		public ArtifactDropManager ArtifactDropManager
		{
			[Token(Token = "0x6006618")]
			[Address(RVA = "0xB19D", Offset = "0xB19D", VA = "0xB19D", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006619")]
			[Address(RVA = "0xB19E", Offset = "0xB19E", VA = "0xB19E")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AE")]
		public CacheManager CacheManager
		{
			[Token(Token = "0x600661A")]
			[Address(RVA = "0xB19F", Offset = "0xB19F", VA = "0xB19F", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600661B")]
			[Address(RVA = "0xB1A0", Offset = "0xB1A0", VA = "0xB1A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014AF")]
		public RequirementsManager RequirementsManager
		{
			[Token(Token = "0x600661C")]
			[Address(RVA = "0xB1A1", Offset = "0xB1A1", VA = "0xB1A1", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600661D")]
			[Address(RVA = "0xB1A2", Offset = "0xB1A2", VA = "0xB1A2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B0")]
		public GameEventsManager GameEventsManager
		{
			[Token(Token = "0x600661E")]
			[Address(RVA = "0xB1A3", Offset = "0xB1A3", VA = "0xB1A3", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600661F")]
			[Address(RVA = "0xB1A4", Offset = "0xB1A4", VA = "0xB1A4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B1")]
		public DailyQuestsManager DailyQuestsManager
		{
			[Token(Token = "0x6006620")]
			[Address(RVA = "0xB1A5", Offset = "0xB1A5", VA = "0xB1A5", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006621")]
			[Address(RVA = "0xB1A6", Offset = "0xB1A6", VA = "0xB1A6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006623 RID: 26147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B2")]
		public DictManager DictManager
		{
			[Token(Token = "0x6006622")]
			[Address(RVA = "0xB1A7", Offset = "0xB1A7", VA = "0xB1A7", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006623")]
			[Address(RVA = "0xB1A8", Offset = "0xB1A8", VA = "0xB1A8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006625 RID: 26149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B3")]
		public ClientStateManager ClientStateManager
		{
			[Token(Token = "0x6006624")]
			[Address(RVA = "0xB1A9", Offset = "0xB1A9", VA = "0xB1A9", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006625")]
			[Address(RVA = "0xB1AA", Offset = "0xB1AA", VA = "0xB1AA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006627 RID: 26151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B4")]
		public BankManager BankManager
		{
			[Token(Token = "0x6006626")]
			[Address(RVA = "0xB1AB", Offset = "0xB1AB", VA = "0xB1AB", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006627")]
			[Address(RVA = "0xB1AC", Offset = "0xB1AC", VA = "0xB1AC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006629 RID: 26153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B5")]
		public BillingManager BillingManager
		{
			[Token(Token = "0x6006628")]
			[Address(RVA = "0xB1AD", Offset = "0xB1AD", VA = "0xB1AD", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006629")]
			[Address(RVA = "0xB1AE", Offset = "0xB1AE", VA = "0xB1AE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B6")]
		public AbstractPrefetchManager AssetsPrefetchManager
		{
			[Token(Token = "0x600662A")]
			[Address(RVA = "0xB1AF", Offset = "0xB1AF", VA = "0xB1AF", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600662B")]
			[Address(RVA = "0xB1B0", Offset = "0xB1B0", VA = "0xB1B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600662D RID: 26157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B7")]
		public ITutorialManager TutorialManager
		{
			[Token(Token = "0x600662C")]
			[Address(RVA = "0xB1B1", Offset = "0xB1B1", VA = "0xB1B1", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600662D")]
			[Address(RVA = "0xB1B2", Offset = "0xB1B2", VA = "0xB1B2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600662F RID: 26159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B8")]
		public ProgressSaverManager SaverProgressManager
		{
			[Token(Token = "0x600662E")]
			[Address(RVA = "0xB1B3", Offset = "0xB1B3", VA = "0xB1B3", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600662F")]
			[Address(RVA = "0xB1B4", Offset = "0xB1B4", VA = "0xB1B4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06006630 RID: 26160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B9")]
		public ShopManager ShopManager
		{
			[Token(Token = "0x6006630")]
			[Address(RVA = "0xB1B5", Offset = "0xB1B5", VA = "0xB1B5", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006631")]
			[Address(RVA = "0xB1B6", Offset = "0xB1B6", VA = "0xB1B6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BA")]
		public SmallGamesManager SmallGamesManager
		{
			[Token(Token = "0x6006632")]
			[Address(RVA = "0xB1B7", Offset = "0xB1B7", VA = "0xB1B7", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006633")]
			[Address(RVA = "0xB1B8", Offset = "0xB1B8", VA = "0xB1B8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BB")]
		public ChatManager ChatManager
		{
			[Token(Token = "0x6006634")]
			[Address(RVA = "0xB1B9", Offset = "0xB1B9", VA = "0xB1B9", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006635")]
			[Address(RVA = "0xB1BA", Offset = "0xB1BA", VA = "0xB1BA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006637 RID: 26167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BC")]
		public GuideManager GuideManager
		{
			[Token(Token = "0x6006636")]
			[Address(RVA = "0xB1BB", Offset = "0xB1BB", VA = "0xB1BB", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006637")]
			[Address(RVA = "0xB1BC", Offset = "0xB1BC", VA = "0xB1BC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06006638 RID: 26168 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006639 RID: 26169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BD")]
		public BlitzTournamentManager BlitzTournamentManager
		{
			[Token(Token = "0x6006638")]
			[Address(RVA = "0xB1BD", Offset = "0xB1BD", VA = "0xB1BD", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006639")]
			[Address(RVA = "0xB1BE", Offset = "0xB1BE", VA = "0xB1BE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x0600663A RID: 26170 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600663B RID: 26171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BE")]
		public TournamentsManager TournamentsManager
		{
			[Token(Token = "0x600663A")]
			[Address(RVA = "0xB1BF", Offset = "0xB1BF", VA = "0xB1BF", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663B")]
			[Address(RVA = "0xB1C0", Offset = "0xB1C0", VA = "0xB1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014BF")]
		public ClientStateResolver ClientStateResolver
		{
			[Token(Token = "0x600663C")]
			[Address(RVA = "0xB1C1", Offset = "0xB1C1", VA = "0xB1C1", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663D")]
			[Address(RVA = "0xB1C2", Offset = "0xB1C2", VA = "0xB1C2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C0")]
		public BattlesManager BattlesManager
		{
			[Token(Token = "0x600663E")]
			[Address(RVA = "0xB1C3", Offset = "0xB1C3", VA = "0xB1C3", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663F")]
			[Address(RVA = "0xB1C4", Offset = "0xB1C4", VA = "0xB1C4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006641 RID: 26177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C1")]
		public SchoolManager SchoolManager
		{
			[Token(Token = "0x6006640")]
			[Address(RVA = "0xB1C5", Offset = "0xB1C5", VA = "0xB1C5", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006641")]
			[Address(RVA = "0xB1C6", Offset = "0xB1C6", VA = "0xB1C6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C2")]
		public SpecialOffersManager SpecialOffersManager
		{
			[Token(Token = "0x6006642")]
			[Address(RVA = "0xB1C7", Offset = "0xB1C7", VA = "0xB1C7", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006643")]
			[Address(RVA = "0xB1C8", Offset = "0xB1C8", VA = "0xB1C8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C3")]
		public RateGameManager RateGameManager
		{
			[Token(Token = "0x6006644")]
			[Address(RVA = "0xB1C9", Offset = "0xB1C9", VA = "0xB1C9", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006645")]
			[Address(RVA = "0xB1CA", Offset = "0xB1CA", VA = "0xB1CA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006647 RID: 26183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C4")]
		public PopupScheduleManager PopupScheduleManager
		{
			[Token(Token = "0x6006646")]
			[Address(RVA = "0xB1CB", Offset = "0xB1CB", VA = "0xB1CB", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006647")]
			[Address(RVA = "0xB1CC", Offset = "0xB1CC", VA = "0xB1CC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006649 RID: 26185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C5")]
		public GolemInventoryManager GolemInventoryManager
		{
			[Token(Token = "0x6006648")]
			[Address(RVA = "0xB1CD", Offset = "0xB1CD", VA = "0xB1CD", Slot = "51")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006649")]
			[Address(RVA = "0xB1CE", Offset = "0xB1CE", VA = "0xB1CE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600664B RID: 26187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C6")]
		public BossManager BossManager
		{
			[Token(Token = "0x600664A")]
			[Address(RVA = "0xB1CF", Offset = "0xB1CF", VA = "0xB1CF", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664B")]
			[Address(RVA = "0xB1D0", Offset = "0xB1D0", VA = "0xB1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600664D RID: 26189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C7")]
		public AccountsManager AccountsManager
		{
			[Token(Token = "0x600664C")]
			[Address(RVA = "0xB1D1", Offset = "0xB1D1", VA = "0xB1D1", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664D")]
			[Address(RVA = "0xB1D2", Offset = "0xB1D2", VA = "0xB1D2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x0600664E RID: 26190 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600664F RID: 26191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C8")]
		public AssistantsManager AssistantsManager
		{
			[Token(Token = "0x600664E")]
			[Address(RVA = "0xB1D3", Offset = "0xB1D3", VA = "0xB1D3", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664F")]
			[Address(RVA = "0xB1D4", Offset = "0xB1D4", VA = "0xB1D4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06006650 RID: 26192 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006651 RID: 26193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014C9")]
		public ICombatManager CombatManager
		{
			[Token(Token = "0x6006650")]
			[Address(RVA = "0xB1D5", Offset = "0xB1D5", VA = "0xB1D5", Slot = "47")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006651")]
			[Address(RVA = "0xB1D6", Offset = "0xB1D6", VA = "0xB1D6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06006652 RID: 26194 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006653 RID: 26195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CA")]
		public GameFeatureRouterManager GameFeatureRouterManager
		{
			[Token(Token = "0x6006652")]
			[Address(RVA = "0xB1D7", Offset = "0xB1D7", VA = "0xB1D7", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006653")]
			[Address(RVA = "0xB1D8", Offset = "0xB1D8", VA = "0xB1D8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006655 RID: 26197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CB")]
		public AudioManager AudioManager
		{
			[Token(Token = "0x6006654")]
			[Address(RVA = "0xB1D9", Offset = "0xB1D9", VA = "0xB1D9", Slot = "48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006655")]
			[Address(RVA = "0xB1DA", Offset = "0xB1DA", VA = "0xB1DA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06006656 RID: 26198 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006657 RID: 26199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CC")]
		public DuelManager DuelManager
		{
			[Token(Token = "0x6006656")]
			[Address(RVA = "0xB1DB", Offset = "0xB1DB", VA = "0xB1DB", Slot = "49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006657")]
			[Address(RVA = "0xB1DC", Offset = "0xB1DC", VA = "0xB1DC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06006658 RID: 26200 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006659 RID: 26201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CD")]
		public ClansManager ClansManager
		{
			[Token(Token = "0x6006658")]
			[Address(RVA = "0xB1DD", Offset = "0xB1DD", VA = "0xB1DD", Slot = "50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006659")]
			[Address(RVA = "0xB1DE", Offset = "0xB1DE", VA = "0xB1DE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600665A RID: 26202 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600665B RID: 26203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CE")]
		public ClanWarsManager ClanWarsManager
		{
			[Token(Token = "0x600665A")]
			[Address(RVA = "0xB1DF", Offset = "0xB1DF", VA = "0xB1DF", Slot = "52")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665B")]
			[Address(RVA = "0xB1E0", Offset = "0xB1E0", VA = "0xB1E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600665C RID: 26204 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600665D RID: 26205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014CF")]
		public DiscountsManager DiscountsManager
		{
			[Token(Token = "0x600665C")]
			[Address(RVA = "0xB1E1", Offset = "0xB1E1", VA = "0xB1E1", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665D")]
			[Address(RVA = "0xB1E2", Offset = "0xB1E2", VA = "0xB1E2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600665E RID: 26206 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600665F RID: 26207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D0")]
		public GameNotificationsManager GameNotificationsManager
		{
			[Token(Token = "0x600665E")]
			[Address(RVA = "0xB1E3", Offset = "0xB1E3", VA = "0xB1E3", Slot = "56")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665F")]
			[Address(RVA = "0xB1E4", Offset = "0xB1E4", VA = "0xB1E4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06006660 RID: 26208 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006661 RID: 26209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D1")]
		public WorldAxisManager WorldAxisManager
		{
			[Token(Token = "0x6006660")]
			[Address(RVA = "0xB1E5", Offset = "0xB1E5", VA = "0xB1E5", Slot = "55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006661")]
			[Address(RVA = "0xB1E6", Offset = "0xB1E6", VA = "0xB1E6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06006662 RID: 26210 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006663 RID: 26211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D2")]
		public AdManager AdManager
		{
			[Token(Token = "0x6006662")]
			[Address(RVA = "0xB1E7", Offset = "0xB1E7", VA = "0xB1E7", Slot = "57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006663")]
			[Address(RVA = "0xB1E8", Offset = "0xB1E8", VA = "0xB1E8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006665 RID: 26213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D3")]
		public ServerTimeManager ServerTimeManager
		{
			[Token(Token = "0x6006664")]
			[Address(RVA = "0xB1E9", Offset = "0xB1E9", VA = "0xB1E9", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006665")]
			[Address(RVA = "0xB1EA", Offset = "0xB1EA", VA = "0xB1EA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006667 RID: 26215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D4")]
		public GdEventsManager GdEventsManager
		{
			[Token(Token = "0x6006666")]
			[Address(RVA = "0xB1EB", Offset = "0xB1EB", VA = "0xB1EB", Slot = "59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006667")]
			[Address(RVA = "0xB1EC", Offset = "0xB1EC", VA = "0xB1EC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006669 RID: 26217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D5")]
		public CollectionsManager CollectionsManager
		{
			[Token(Token = "0x6006668")]
			[Address(RVA = "0xB1ED", Offset = "0xB1ED", VA = "0xB1ED", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006669")]
			[Address(RVA = "0xB1EE", Offset = "0xB1EE", VA = "0xB1EE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600666A RID: 26218 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600666B RID: 26219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D6")]
		public TokensManager TokensManager
		{
			[Token(Token = "0x600666A")]
			[Address(RVA = "0xB1EF", Offset = "0xB1EF", VA = "0xB1EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600666B")]
			[Address(RVA = "0xB1F0", Offset = "0xB1F0", VA = "0xB1F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600666C RID: 26220 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600666D RID: 26221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D7")]
		public ThemeDuelStateManager ThemeDuelStateManager
		{
			[Token(Token = "0x600666C")]
			[Address(RVA = "0xB1F1", Offset = "0xB1F1", VA = "0xB1F1", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600666D")]
			[Address(RVA = "0xB1F2", Offset = "0xB1F2", VA = "0xB1F2")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600666F RID: 26223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D8")]
		public PortalsManager PortalsManager
		{
			[Token(Token = "0x600666E")]
			[Address(RVA = "0xB1F3", Offset = "0xB1F3", VA = "0xB1F3", Slot = "62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600666F")]
			[Address(RVA = "0xB1F4", Offset = "0xB1F4", VA = "0xB1F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006671 RID: 26225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D9")]
		public EndlessPaymentOptionsListManager EndlessPaymentOptionsListManager
		{
			[Token(Token = "0x6006670")]
			[Address(RVA = "0xB1F5", Offset = "0xB1F5", VA = "0xB1F5", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006671")]
			[Address(RVA = "0xB1F6", Offset = "0xB1F6", VA = "0xB1F6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006673 RID: 26227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DA")]
		public CompetitionManager CompetitionManager
		{
			[Token(Token = "0x6006672")]
			[Address(RVA = "0xB1F7", Offset = "0xB1F7", VA = "0xB1F7", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006673")]
			[Address(RVA = "0xB1F8", Offset = "0xB1F8", VA = "0xB1F8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06006674 RID: 26228 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006675 RID: 26229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DB")]
		public FrescoManager FrescoManager
		{
			[Token(Token = "0x6006674")]
			[Address(RVA = "0xB1F9", Offset = "0xB1F9", VA = "0xB1F9", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006675")]
			[Address(RVA = "0xB1FA", Offset = "0xB1FA", VA = "0xB1FA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DC")]
		public IRouter Router
		{
			[Token(Token = "0x6006676")]
			[Address(RVA = "0xB1FB", Offset = "0xB1FB", VA = "0xB1FB", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006677")]
			[Address(RVA = "0xB1FC", Offset = "0xB1FC", VA = "0xB1FC")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006679 RID: 26233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DD")]
		public SkinManager Skins
		{
			[Token(Token = "0x6006678")]
			[Address(RVA = "0xB1FD", Offset = "0xB1FD", VA = "0xB1FD", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006679")]
			[Address(RVA = "0xB1FE", Offset = "0xB1FE", VA = "0xB1FE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600667A RID: 26234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600667B RID: 26235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DE")]
		public ExperimentsManager ExperimentsManager
		{
			[Token(Token = "0x600667A")]
			[Address(RVA = "0xB1FF", Offset = "0xB1FF", VA = "0xB1FF", Slot = "68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600667B")]
			[Address(RVA = "0xB200", Offset = "0xB200", VA = "0xB200")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667C")]
		[Address(RVA = "0xB201", Offset = "0xB201", VA = "0xB201", Slot = "69")]
		protected virtual void CreateGameManagers()
		{
		/* --- GHIDRA: CreateGameManagers ---
		void Core_Gameplay_AbstractGame__CreateGameManagers(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  undefined4 param4;
		  int iVar4;
		  undefined4 local_30 [2];
		  undefined8 local_28;
		  int local_20;
		  undefined1 local_1c [8];
		  undefined8 local_14;
		  int local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a8ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_AbstractGame_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10696);
		    DAT_ram_00a5a8ff = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x18) + 0xc) + -1 < *(int *)(param1 + 0x1c)) {
		    if (DAT_ram_00a5a903 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractGame__InitCompleted_d__257___
		                );
		      DAT_ram_00a5a903 = '\x01';
		    }
		    local_8 = 0;
		    System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(local_30,0);
		    local_14 = local_28;
		    local_20 = -1;
		    local_c = param1;
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractAdController__InitializeAdProviders_d__7_
		              (local_1c,&local_20,
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractGame__InitCompleted_d__257___
		              );
		  }
		  else {
		    uVar1 = 0;
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (*(int *)(param1 + 0x18),*(int *)(param1 + 0x1c),
		                                  Method_System_Collections_Generic_List_IGameManager__get_Item__);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x8128c359;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x8128c359:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    local_20 = *(int *)(param1 + 0x1c) + 1;
		    param3 = func_ii_1081(DAT_ram_00a66954,&local_20);
		    local_30[0] = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		    param4 = func_ii_1081(DAT_ram_00a66954,local_30);
		    uVar3 = func_ii_8529(StringLiteral_10696,uVar3,param3,param4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		    uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Core_Gameplay_AbstractGame_ManagerInitComplete__,0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8128c466;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,0);
		code_r0x8128c466:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x8128c4e2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,4);
		code_r0x8128c4e2:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600667D RID: 26237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667D")]
		[Address(RVA = "0xB202", Offset = "0xB202", VA = "0xB202")]
		private void HandleInitManagersQueue()
		{
		/* --- GHIDRA: HandleInitManagersQueue ---
		void Core_Gameplay_AbstractGame__HandleInitManagersQueue(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  undefined4 param4;
		  int iVar4;
		  undefined4 local_8;
		  int local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a900 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_AbstractGame_ManagerDeinitComplete__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_AbstractGame_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10694);
		    DAT_ram_00a5a900 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) < 0) {
		    Core_Gameplay_AbstractGame__InitCompleted(param1,0);
		  }
		  else {
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (*(undefined4 *)(param1 + 0x18),*(int *)(param1 + 0x1c),
		                                  Method_System_Collections_Generic_List_IGameManager__get_Item__);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x8128c655;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x8128c655:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    local_4 = *(int *)(param1 + 0x1c) + 1;
		    param3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    local_8 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		    param4 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar3 = func_ii_8529(StringLiteral_10694,uVar3,param3,param4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		    uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Core_Gameplay_AbstractGame_ManagerDeinitComplete__,0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x8128c765;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,2);
		code_r0x8128c765:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar3,puVar2[1]);
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Core_Gameplay_AbstractGame_ManagerInitComplete__,0);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x8128c800;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,1);
		code_r0x8128c800:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		          goto code_r0x8128c87c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,5);
		code_r0x8128c87c:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600667E RID: 26238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667E")]
		[Address(RVA = "0xB203", Offset = "0xB203", VA = "0xB203")]
		private void HandleDeinitManagersQueue()
		{
		/* --- GHIDRA: HandleDeinitManagersQueue ---
		void Core_Gameplay_AbstractGame__HandleDeinitManagersQueue(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param5;
		  undefined4 param6;
		  int *param1_01;
		  int iVar6;
		  int iVar7;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a901 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_AbstractGame_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AppScope_LoadingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10695);
		    DAT_ram_00a5a901 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_AbstractGame_ManagerInitComplete__,0);
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x8128cbea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,1);
		code_r0x8128cbea:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  iVar7 = System_Uri___ctor(0);
		  iVar7 = *(int *)(*(int *)(*(int *)(*(int *)(iVar7 + 0x38) + 0x10) + 0x1c) + 0x28);
		  if (iVar7 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    uVar4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf0);
		          goto code_r0x8128ccb2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,6);
		code_r0x8128ccb2:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    param5 = *(undefined4 *)(param1 + 0x1c);
		    param6 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AppScope_LoadingEventArgs_TypeInfo);
		    Core_Events_Scopes_TournamentsScope_AddBetEventArgs__get_Bet
		              (param1_00,uVar2,uVar4,uVar5,param5,param6,0);
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),param1_00,*(undefined4 *)(iVar7 + 0x14));
		  }
		  *(int *)(param1 + 0x1c) = *(int *)(param1 + 0x1c) + 1;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xf0);
		        goto code_r0x8128cd80;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,6);
		code_r0x8128cd80:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_4 = *(undefined4 *)(param1 + 0x1c);
		  uVar4 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		  uVar5 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar2 = func_ii_8529(StringLiteral_10695,uVar2,uVar4,uVar5,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  param1_01 = *(int **)(param1 + 0x10);
		  iVar7 = *param1_01;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		        goto code_r0x8128ce71;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8128ce71:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Preloading_Preloader__Show
		            (*(undefined4 *)(iVar7 + 0x1c),
		             (float)*(int *)(param1 + 0x1c) / (float)*(int *)(*(int *)(param1 + 0x18) + 0xc),3,0);
		  Core_Gameplay_AbstractGame__CreateGameManagers(param1,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x0600667F RID: 26239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667F")]
		[Address(RVA = "0xB204", Offset = "0xB204", VA = "0xB204")]
		private void ManagerInitComplete(IBaseManager manager)
		{
		/* --- GHIDRA: ManagerInitComplete ---
		void Core_Gameplay_AbstractGame__ManagerInitComplete(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param3_00;
		  undefined4 param4;
		  int iVar4;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5a902 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_AbstractGame_ManagerDeinitComplete__);
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10693);
		    DAT_ram_00a5a902 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_AbstractGame_ManagerDeinitComplete__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x8128cf8f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,3);
		code_r0x8128cf8f:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x8128d00b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,6);
		code_r0x8128d00b:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_4 = *(int *)(param1 + 0x1c) + 1;
		  param3_00 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		  param4 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar2 = func_ii_8529(StringLiteral_10693,uVar2,param3_00,param4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  *(int *)(param1 + 0x1c) = *(int *)(param1 + 0x1c) + -1;
		  Core_Gameplay_AbstractGame__HandleInitManagersQueue(param1,uVar2);
		  return;
		}
		*/

		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006680")]
		[Address(RVA = "0xB205", Offset = "0xB205", VA = "0xB205")]
		private void ManagerDeinitComplete(IBaseManager manager)
		{
		/* --- GHIDRA: ManagerDeinitComplete ---
		void Core_Gameplay_AbstractGame__ManagerDeinitComplete(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a903 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractGame__InitCompleted_d__257___
		              );
		    DAT_ram_00a5a903 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractAdController__InitializeAdProviders_d__7_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractGame__InitCompleted_d__257___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006681 RID: 26241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006681")]
		[Address(RVA = "0xB206", Offset = "0xB206", VA = "0xB206")]
		private void InitCompleted()
		{
		/* --- GHIDRA: InitCompleted ---
		void Core_Gameplay_AbstractGame__InitCompleted(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a904 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28722);
		    DAT_ram_00a5a904 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined2 *)(param1 + 0x14) = 0;
		  param1_00 = func_ii_4419(StringLiteral_28722,param1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006682 RID: 26242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006682")]
		[Address(RVA = "0xB207", Offset = "0xB207", VA = "0xB207")]
		private void DeinitCompleted()
		{
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006683")]
		[Address(RVA = "0xB208", Offset = "0xB208", VA = "0xB208")]
		protected AbstractGame()
		{
		}

		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x18")]
		private List<IGameManager> _managers;

		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x1C")]
		private int _currentIndex;

		// Token: 0x04003693 RID: 13971
		[Token(Token = "0x4003693")]
		[FieldOffset(Offset = "0x20")]
		private readonly CancellationTokenSource _cancellationSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_AbstractGame__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    DAT_ram_00a5a8f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGame__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGame__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_AbstractGame__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    DAT_ram_00a5a8fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGame__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGame__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_AbstractGame__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a8fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    DAT_ram_00a5a8fb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGame__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGame__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_IsDeInitProcess ---
		void Core_Gameplay_AbstractGame__set_IsDeInitProcess(int *param1,int param2,undefined4 param3)
		
		{
		  param1[7] = 0;
		  param1[4] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Core_Gameplay_AbstractGame__CreateGameManagers(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_ExperimentsManager ---
		void Core_Gameplay_AbstractGame__set_ExperimentsManager(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a8fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_CombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IGameManager__TypeInfo);
		    DAT_ram_00a5a8fe = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_IGameManager__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_IGameManager___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = unnamed_function_1417(Core_Gameplay_Managers_CombatManager_TypeInfo);
		  Core_Gameplay_Managers_CombatManager__StopCurrentCombat(uVar2,0);
		  *(undefined4 *)(param1 + 0xb0) = uVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  param1_00 = *(int *)(param1 + 0x18);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

}
