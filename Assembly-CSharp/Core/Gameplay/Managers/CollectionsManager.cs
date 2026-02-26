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
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_CollectionsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a6378d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a6378d = '\x01';
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x1c),0);
		  iVar3 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar3 + 0xec));
		  iVar3 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar3 + 0xec));
		  param1_00 = *(int **)(param1 + 0x24);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x822fcdc9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x822fcdc9:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar3 = *(int *)(param1 + 0x10);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A8")]
		[Address(RVA = "0xB3D2", Offset = "0xB3D2", VA = "0xB3D2", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_CollectionsManager__Deinit(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6378e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_CollectionsManager_InitEventHandler__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo);
		    DAT_ram_00a6378e = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x18);
		  param1_01 = *(undefined4 *)(iVar2 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_CollectionsManager_InitEventHandler__,0)
		  ;
		  piVar1 = (int *)func_ii_7048(param1_01,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (piVar1 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar1) ||
		          (*(int **)(iVar2 + 8) = piVar1, *piVar1 != param2_00)) {
		    System_Activator__CreateInstance(piVar1,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar1 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar1 + 100) +
		                 (uint)*(byte *)(Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo +
		                                0xb8) * 4 + -4) !=
		        Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar1,Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Collections_Model_CollectionDicGroup__AddRank
		            (piVar1,*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0xB3D3", Offset = "0xB3D3", VA = "0xB3D3")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Core_Gameplay_Managers_CollectionsManager__InitEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0xB3D4", Offset = "0xB3D4", VA = "0xB3D4")]
		public void ShowOwnCollectionsWindow()
		{
		/* --- GHIDRA: ShowOwnCollectionsWindow ---
		void Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a63790 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12600);
		    DAT_ram_00a63790 = '\x01';
		  }
		  if (param2 == *(int *)(*(int *)(param1 + 0x14) + 8)) {
		    Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow(param1,0,0);
		    return;
		  }
		  piVar3 = *(int **)(param1 + 8);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x822fd176;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fd176:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x822fd1f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x822fd1f8:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(param1 + 8);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo)
		  ;
		  Gameplay_Collections_View_CollectionsWindow___ctor(param1_01,param2,param3_00,param4,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12600,param1_01,
		             Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: ShowOwnCollectionsWindow ---
		void Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a63790 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12600);
		    DAT_ram_00a63790 = '\x01';
		  }
		  if (param2 == *(int *)(*(int *)(param1 + 0x14) + 8)) {
		    Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow(param1,0,0);
		    return;
		  }
		  piVar3 = *(int **)(param1 + 8);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x822fd176;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fd176:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x822fd1f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x822fd1f8:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(param1 + 8);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo)
		  ;
		  Gameplay_Collections_View_CollectionsWindow___ctor(param1_01,param2,param3_00,param4,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12600,param1_01,
		             Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		  return;
		}
		*/

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
		/* --- GHIDRA: ShowCollectionsWindow ---
		void Core_Gameplay_Managers_CollectionsManager__ShowCollectionsWindow
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a63791 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionInfoWindow_CollectionInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12599);
		    DAT_ram_00a63791 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 8);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x822fd300;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fd300:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x822fd382;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x822fd382:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(param1 + 0x1c);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Collections_View_CollectionInfoWindow_CollectionInfoWindowArgs_TypeInfo
		                        );
		  Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__HandleCollectionView_27_2
		            (param1_01,param2_00,param3_00,param2,param3,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12599,param1_01,
		             Method_UI_Windows_PopupController_Show_CollectionInfoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0xB3D7", Offset = "0xB3D7", VA = "0xB3D7")]
		public void ShowCollectionInfoWindow(uint collectionId, uint rank)
		{
		/* --- GHIDRA: ShowCollectionInfoWindow ---
		undefined4
		Core_Gameplay_Managers_CollectionsManager__ShowCollectionInfoWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63792 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5599);
		    DAT_ram_00a63792 = '\x01';
		  }
		  return StringLiteral_5599;
		}
		*/

		}

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x24")]
		private ICollectionDataFactory _collectionDataFactory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_Managers_CollectionsManager__set_Game
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63788 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63788 = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_CollectionsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63789 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63789 = '\x01';
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_CollectionsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6378a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6378a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
		void Core_Gameplay_Managers_CollectionsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6378b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6378b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: set_MaterialsStorage ---
		void Core_Gameplay_Managers_CollectionsManager__set_MaterialsStorage(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 param5;
		  int iVar8;
		  
		  if (DAT_ram_00a6378c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Controller_CollectionsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Events_CollectionsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_CollectionsManager_InitEventHandler__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6378c = '\x01';
		  }
		  uVar3 = unnamed_function_1417(Gameplay_Collections_Model_CollectionsMaterialsStorage_TypeInfo);
		  Gameplay_Collections_Model_CollectionsMaterialsStorage__Dispose(uVar3,0);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  piVar6 = *(int **)(param1 + 8);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x822fca9d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x822fca9d:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = unnamed_function_1417(Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo)
		  ;
		  Gameplay_Collections_Model_Factories_CollectionDataFactory__Dispose(uVar5,uVar3,0);
		  *(undefined4 *)(param1 + 0x24) = uVar5;
		  piVar6 = *(int **)(param1 + 8);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x822fcb3e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x822fcb3e:
		  uVar3 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    uVar3 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  piVar6 = *(int **)(param1 + 8);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x822fcbd4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x822fcbd4:
		  uVar2 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  param5 = *(undefined4 *)(param1 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Collections_Model_CollectionsModel_TypeInfo);
		  Gameplay_Collections_Model_CollectionsModel__Dispose(param1_00,uVar5,uVar3,uVar2,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar3 = unnamed_function_1417(Gameplay_Collections_Events_CollectionsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar5 = unnamed_function_1417(Gameplay_Collections_Controller_CollectionsController_TypeInfo);
		  Gameplay_Collections_Controller_CollectionInfoViewMediator__UpgradeButtonClickEventHandler
		            (uVar5,uVar2,uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar5;
		  MVC_AbstractController__Dispose(uVar5,0);
		  iVar8 = *(int *)(param1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar8 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_CollectionsManager_InitEventHandler__,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(iVar8 + 8) = piVar6, *piVar6 != iVar7))
		  {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = *(int *)(param1 + 0xc);
		  if (iVar7 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  }
		  return;
		}
		*/

}
