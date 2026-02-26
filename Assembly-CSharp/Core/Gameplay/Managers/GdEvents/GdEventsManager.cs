using System;
using System.Runtime.CompilerServices;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GdEvents
{
	// Token: 0x020011C2 RID: 4546
	[Token(Token = "0x20011C2")]
	public class GdEventsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001623")]
		public string Name
		{
			[Token(Token = "0x6006C42")]
			[Address(RVA = "0xB72F", Offset = "0xB72F", VA = "0xB72F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002C7 RID: 711
		// (add) Token: 0x06006C43 RID: 27715 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C44 RID: 27716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C7")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C43")]
			[Address(RVA = "0xB730", Offset = "0xB730", VA = "0xB730", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C44")]
			[Address(RVA = "0xB731", Offset = "0xB731", VA = "0xB731", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C8 RID: 712
		// (add) Token: 0x06006C45 RID: 27717 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C46 RID: 27718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C8")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C45")]
			[Address(RVA = "0xB732", Offset = "0xB732", VA = "0xB732", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C46")]
			[Address(RVA = "0xB733", Offset = "0xB733", VA = "0xB733", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C48 RID: 27720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001624")]
		public GdEventsController Controller
		{
			[Token(Token = "0x6006C47")]
			[Address(RVA = "0xB734", Offset = "0xB734", VA = "0xB734")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C48")]
			[Address(RVA = "0xB735", Offset = "0xB735", VA = "0xB735")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0xB736", Offset = "0xB736", VA = "0xB736")]
		public GdEventsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GdEvents_GdEventsManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param3;
		  undefined4 param5;
		  undefined4 param7;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 param4;
		  int *piVar9;
		  undefined4 param6;
		  
		  if (DAT_ram_00a5a6da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_TriggerDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_TriggerDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_TriggerDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_GdEventsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_GdEvents_GdEventsManager___c__Init_b__15_0__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo);
		    DAT_ram_00a5a6da = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8125a916;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125a916:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar4 = unnamed_function_1417(Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo)
		  ;
		  Gameplay_Collections_Model_Factories_CollectionDataFactory__Dispose(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8125a9b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125a9b7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar7 + 0x74);
		  if (*(int *)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x5c);
		  iVar7 = puVar8[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar4 = *puVar8;
		    iVar7 = unnamed_function_1417(System_Func_TriggerDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar7,uVar4,
		               Method_Core_Gameplay_Managers_GdEvents_GdEventsManager___c__Init_b__15_0__,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x5c) + 4) =
		         iVar7;
		  }
		  uVar1 = 0;
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar7,Method_System_Linq_Enumerable_Where_TriggerDic___);
		  uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_TriggerDic___);
		  uVar4 = unnamed_function_1417(Gameplay_GdEvents_GdEventsEvents_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x2b0);
		        goto code_r0x8125aaee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3e);
		code_r0x8125aaee:
		  uVar1 = 0;
		  param3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  param4 = *(undefined4 *)(param1 + 0x18);
		  piVar9 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x8125ab7a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8125ab7a:
		  uVar1 = 0;
		  param5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x270);
		        goto code_r0x8125abff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x36);
		code_r0x8125abff:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  param6 = *(undefined4 *)(iVar7 + 0x10);
		  uVar1 = 0;
		  piVar9 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8125ac87;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125ac87:
		  uVar1 = 0;
		  param7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8125ad0c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125ad0c:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  param1_00 = unnamed_function_1417(Gameplay_GdEvents_Model_GdEventsModel_TypeInfo);
		  Gameplay_GdEvents_Model_GdEventsModel__Dispose
		            (param1_00,piVar6,param3,param4,param5,param6,param7,uVar3,uVar5,0);
		  uVar3 = unnamed_function_1417(Gameplay_GdEvents_Control_GdEventsController_TypeInfo);
		  Gameplay_GdEvents_Control_GdEventWindowViewMediator__HandleTabBarChangedEvent
		            (uVar3,param1_00,uVar4,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  MVC_AbstractController__Dispose(uVar3,0);
		  iVar7 = *(int *)(param1 + 8);
		  if (iVar7 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0xB737", Offset = "0xB737", VA = "0xB737", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a6db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a6db = '\x01';
		  }
		  iVar4 = **(int **)(param1 + 0x10);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xec));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xec));
		  piVar2 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8125ae7b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_IDisposable_TypeInfo,0);
		code_r0x8125ae7b:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar4 = *(int *)(param1 + 0xc);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0xB738", Offset = "0xB738", VA = "0xB738", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__Deinit(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a6dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo);
		    DAT_ram_00a5a6dc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_GdEvents_GdEventsManager___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x14")]
		private IGame _game;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x18")]
		private ICollectionDataFactory _collectionDataFactory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6d6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6d7 = '\x01';
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
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6d8 = '\x01';
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
		void Core_Gameplay_Managers_GdEvents_GdEventsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6d9 = '\x01';
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

}
