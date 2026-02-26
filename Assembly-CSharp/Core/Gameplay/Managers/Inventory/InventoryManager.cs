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
		/* --- GHIDRA: <SellItem>b__42_0 ---
		undefined4
		Core_Gameplay_Managers_Inventory_InventoryManager___SellItem_b__42_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a6d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8447);
		    DAT_ram_00a5a6d5 = '\x01';
		  }
		  return StringLiteral_8447;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Inventory_InventoryManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param1_00;
		  undefined4 uVar8;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int *piVar9;
		  int iVar10;
		  int iVar11;
		  
		  if (DAT_ram_00a5a6cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ArtifactComparerModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddleware_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_InventoryController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Inventory_InventoryManager_ControllerInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a6cc = '\x01';
		  }
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x140);
		        goto code_r0x81259985;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81259985:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xe0);
		        goto code_r0x81259a10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81259a10:
		  piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar1 = 0;
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf0);
		        goto code_r0x81259a90;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,6);
		code_r0x81259a90:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x158);
		        goto code_r0x81259b15;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x81259b15:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar5 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar5,0);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x160);
		        goto code_r0x81259ba0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x81259ba0:
		  uVar1 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x81259c25;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81259c25:
		  uVar1 = 0;
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  param1_00 = unnamed_function_1417(Gameplay_Inventory_Model_InventoryModel_TypeInfo);
		  Gameplay_Inventory_Model_InventoryMetaFilterData___ctor
		            (param1_00,2,uVar4,uVar5,uVar6,uVar7,uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  uVar4 = *(undefined4 *)(param1 + 0x20);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x81259cd7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81259cd7:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x1b0);
		        goto code_r0x81259d5c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x81259d5c:
		  uVar1 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xe0);
		        goto code_r0x81259de1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81259de1:
		  piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar1 = 0;
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf8);
		        goto code_r0x81259e61;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,7);
		code_r0x81259e61:
		  uVar1 = 0;
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x28);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xe0);
		        goto code_r0x81259ee6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81259ee6:
		  piVar9 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar1 = 0;
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf0);
		        goto code_r0x81259f68;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,6);
		code_r0x81259f68:
		  uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware_TypeInfo);
		  Pathfinding_Ionic_Zlib_InternalConstants___cctor(param1_01,uVar5,uVar6,uVar7,uVar8,0xb,0);
		  iVar10 = *(int *)(param1 + 0x10);
		  uVar6 = *(undefined4 *)(iVar10 + 8);
		  uVar5 = unnamed_function_1417
		                    (Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddleware_TypeInfo);
		  Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___c__DisplayClass6_0___ShowRecipeLearnedWindow_b__0
		            (uVar5,iVar10,uVar6,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar6 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar7 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar8 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  param1_02 = unnamed_function_1417(Gameplay_Inventory_Controller_InventoryController_TypeInfo);
		  Gameplay_Inventory_Controller_InventoryController__Dispose
		            (param1_02,param1_00,uVar4,param1_01,uVar5,uVar6,uVar7,uVar8,0);
		  *(undefined4 *)(param1 + 0x14) = param1_02;
		  uVar5 = *(undefined4 *)(param1 + 0x20);
		  uVar4 = unnamed_function_1417
		                    (Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(uVar4,uVar5,0);
		  *(undefined4 *)(param1 + 0x24) = uVar4;
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_ArtifactComparer_Model_ArtifactComparerModel_TypeInfo);
		  Gameplay_ArtifactComparer_Model_ArtifactComparerModel__set_EnabledSkillIds(uVar4,uVar3,uVar5,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  uVar5 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = unnamed_function_1417
		                    (Gameplay_ArtifactComparer_Controller_ArtifactComparerController_TypeInfo);
		  Gameplay_ArtifactComparer_Model_ComparerValueRow___ctor(uVar3,uVar4,uVar5,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  iVar11 = *(int *)(param1 + 0x20);
		  uVar4 = *(undefined4 *)(iVar11 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Inventory_InventoryManager_ControllerInitEvent__,0);
		  piVar9 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar10 = System_Action_TypeInfo;
		  if (piVar9 == (int *)0x0) {
		    *(undefined4 *)(iVar11 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar9) ||
		          (*(int **)(iVar11 + 8) = piVar9, *piVar9 != iVar10)) {
		    System_Activator__CreateInstance(piVar9,iVar10);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C33")]
		[Address(RVA = "0xB720", Offset = "0xB720", VA = "0xB720", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a6cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Inventory_InventoryManager_ControllerInitEvent__);
		    DAT_ram_00a5a6cd = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Inventory_InventoryManager_ControllerInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C34")]
		[Address(RVA = "0xB721", Offset = "0xB721", VA = "0xB721")]
		private void ControllerInitEvent()
		{
		/* --- GHIDRA: ControllerInitEvent ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__ControllerInitEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  puVar1 = (undefined8 *)(param1 + 0x18);
		  MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)puVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		  *puVar1 = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C35")]
		[Address(RVA = "0xB722", Offset = "0xB722", VA = "0xB722", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Gameplay_Managers_Inventory_InventoryManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a6ce == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_9770);
		    DAT_ram_00a5a6ce = '\x01';
		  }
		  return StringLiteral_9770;
		}
		*/

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
		/* --- GHIDRA: BuySlots ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__BuySlots
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param3_00;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Inventory_InventoryManager__SellItem_b__42_0__);
		    DAT_ram_00a5a6cf = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x70);
		  uVar1 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Inventory_InventoryManager__SellItem_b__42_0__,0);
		  param3_00 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		  iVar2 = func_ii_1082(param2,*(undefined4 *)(*param3_00 + 0x20));
		  if (iVar2 == 0) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3_00[4] = param2;
		  UI_Windows_ConfirmSellUserArtifactWindow__HandleContent(param1_00,uVar1,param3_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0xB725", Offset = "0xB725", VA = "0xB725")]
		public void SellItem(ArtifactData artifactData)
		{
		/* --- GHIDRA: SellItem ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__SellItem
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Inventory_Controller_InventoryController__SellArtifactSuccessHandler
		            (*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

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
		/* --- GHIDRA: MoveItemToChest ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__MoveItemToChest
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a6d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Unequip__
		              );
		    DAT_ram_00a5a6d0 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___ShowNotAvailableSlotsWindow
		            (*(undefined4 *)(param1 + 0x14),param2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Unequip__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3B")]
		[Address(RVA = "0xB728", Offset = "0xB728", VA = "0xB728")]
		public void UnEquip(ArtifactData artifact)
		{
		/* --- GHIDRA: UnEquip ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__UnEquip
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a6d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Equip__
		              );
		    DAT_ram_00a5a6d1 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Dispose
		            (*(undefined4 *)(param1 + 0x14),param2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__Equip__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3C")]
		[Address(RVA = "0xB729", Offset = "0xB729", VA = "0xB729")]
		public void Equip(ArtifactData artifact)
		{
		/* --- GHIDRA: Equip ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__Equip
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x128) * 4))
		            (*(int **)(param1 + 0x14),param2,param3,param4,*(undefined4 *)(iVar1 + 300));
		  return;
		}
		*/

		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3D")]
		[Address(RVA = "0xB72A", Offset = "0xB72A", VA = "0xB72A")]
		public void DismantleArtifact(ArtifactData artifactData, bool sellDrop = false, bool wholestack = false)
		{
		/* --- GHIDRA: DismantleArtifact ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a6d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_UserInventoryChestWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12643);
		    DAT_ram_00a5a6d2 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x20) = param4;
		  *(undefined4 *)(param1_00 + 0x1c) = param3;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12643,param1_00,
		             Method_UI_Windows_PopupController_Show_UserInventoryChestWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0xB72B", Offset = "0xB72B", VA = "0xB72B")]
		public void ShowChestWindow(ArtikulMenuActionDic.Types.Actions[] customActions, ArtikulMenuActionDic.Types.Actions[] closeWindowActions, InventoryChestWindowOptions.ArtifactFilterDelegate customFilterFunction)
		{
		/* --- GHIDRA: ShowChestWindow ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a6d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12633);
		    DAT_ram_00a5a6d4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x24);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  *(undefined1 *)(param1_00 + 0x28) = 0;
		  *(undefined4 *)(param1_00 + 0x24) = uVar2;
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  iVar1 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar2,Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		  if ((iVar1 != 0) && (*(int *)(iVar1 + 0xc) != 0)) {
		    Gameplay_ArtifactComparer_View_ArtifactComparerWindow__InitMvc
		              (*(undefined4 *)(iVar1 + 0x10),param1_00,0);
		    return;
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12633,param1_00,
		             Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: ShowChestWindow ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a6d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12633);
		    DAT_ram_00a5a6d4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactComparer_View_ArtifactComparerWindow_ArtifactComparerWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x24);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  *(undefined1 *)(param1_00 + 0x28) = 0;
		  *(undefined4 *)(param1_00 + 0x24) = uVar2;
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  iVar1 = UI_Windows_PopupController__GetLastWindow_object_
		                    (uVar2,Method_UI_Windows_PopupController_GetWindows_ArtifactComparerWindow___);
		  if ((iVar1 != 0) && (*(int *)(iVar1 + 0xc) != 0)) {
		    Gameplay_ArtifactComparer_View_ArtifactComparerWindow__InitMvc
		              (*(undefined4 *)(iVar1 + 0x10),param1_00,0);
		    return;
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12633,param1_00,
		             Method_UI_Windows_PopupController_Show_ArtifactComparerWindow___);
		  return;
		}
		*/

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
		/* --- GHIDRA: ShowArtifactComparerWindow ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__ShowArtifactComparerWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  
		  uVar3 = 0;
		  uVar2 = *(uint *)(param2 + 0xc);
		  if (0 < (int)uVar2) {
		    iVar1 = 0;
		    if (uVar2 != 1) {
		      do {
		        iVar4 = **(int **)(param1 + 0x14);
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0x150) * 4))
		                  (*(int **)(param1 + 0x14),*(undefined4 *)(param2 + 0x10 + iVar1 * 4),
		                   *(undefined4 *)(iVar4 + 0x154));
		        iVar4 = **(int **)(param1 + 0x14);
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0x150) * 4))
		                  (*(int **)(param1 + 0x14),*(undefined4 *)(param2 + 0x10 + (iVar1 * 4 | 4U)),
		                   *(undefined4 *)(iVar4 + 0x154));
		        iVar1 = iVar1 + 2;
		        uVar3 = uVar3 + 2;
		      } while (uVar3 != (uVar2 & 0xfffffffe));
		    }
		    if ((uVar2 & 1) != 0) {
		      iVar4 = **(int **)(param1 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x150) * 4))
		                (*(int **)(param1 + 0x14),*(undefined4 *)(param2 + iVar1 * 4 + 0x10),
		                 *(undefined4 *)(iVar4 + 0x154));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x040038F4 RID: 14580
		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x28")]
		private readonly IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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
		void Core_Gameplay_Managers_Inventory_InventoryManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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
		void Core_Gameplay_Managers_Inventory_InventoryManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6ca = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: set_ComparerEvents ---
		void Core_Gameplay_Managers_Inventory_InventoryManager__set_ComparerEvents
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a6cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_InventoryEvents_TypeInfo);
		    DAT_ram_00a5a6cb = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Inventory_Controller_InventoryEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		undefined4
		Core_Gameplay_Managers_Inventory_InventoryManager__get_Name
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                    (*(int **)(param1 + 0x14),param2,*(undefined4 *)(iVar2 + 0x14c));
		  return uVar1;
		}
		*/

}
