using System;
using System.Runtime.CompilerServices;
using Gameplay.EndlessPaymentOptionsList.Control;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;

namespace Core.Gameplay.Managers.EndlessPaymentOptionsList
{
	// Token: 0x020011EF RID: 4591
	[Token(Token = "0x20011EF")]
	public class EndlessPaymentOptionsListManager : IGameManager, IBaseManager
	{
		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001631")]
		public string Name
		{
			[Token(Token = "0x6006D05")]
			[Address(RVA = "0xB7EE", Offset = "0xB7EE", VA = "0xB7EE", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002CD RID: 717
		// (add) Token: 0x06006D06 RID: 27910 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D07 RID: 27911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D06")]
			[Address(RVA = "0xB7EF", Offset = "0xB7EF", VA = "0xB7EF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D07")]
			[Address(RVA = "0xB7F0", Offset = "0xB7F0", VA = "0xB7F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CE RID: 718
		// (add) Token: 0x06006D08 RID: 27912 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D09 RID: 27913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D08")]
			[Address(RVA = "0xB7F1", Offset = "0xB7F1", VA = "0xB7F1", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D09")]
			[Address(RVA = "0xB7F2", Offset = "0xB7F2", VA = "0xB7F2", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0xB7F3", Offset = "0xB7F3", VA = "0xB7F3")]
		public EndlessPaymentOptionsListManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param7;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  
		  if (DAT_ram_00a5a741 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_EndlessPaymentOptionsListEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_EndlessPaymentOptionsReceivedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_HandleControllerInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_UnScheduleShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a741 = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x270);
		        goto code_r0x812646ad;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x36);
		code_r0x812646ad:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x10);
		  uVar1 = 0;
		  piVar9 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x81264735;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81264735:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 400);
		        goto code_r0x812647ba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x812647ba:
		  uVar1 = 0;
		  param7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  piVar9 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8126483f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126483f:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel_TypeInfo
		                        );
		  Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_AllCards
		            (param1_00,10,4,piVar6,uVar8,uVar3,param7,uVar4,0);
		  uVar8 = unnamed_function_1417
		                    (Gameplay_EndlessPaymentOptionsList_EndlessPaymentOptionsListEvents_TypeInfo);
		  piVar6 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController_TypeInfo
		                            );
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListController__Dispose
		            (piVar6,param1_00,uVar8,0);
		  *(int **)(param1 + 0x14) = piVar6;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x110) * 4))
		                    (piVar6,*(undefined4 *)(*piVar6 + 0x114));
		  uVar3 = *(undefined4 *)(iVar5 + 8);
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_HandleControllerInitEvent__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar3,uVar8,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(iVar5 + 8) = piVar6, *piVar6 != iVar7))
		  {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = **(int **)(param1 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar3 = *(undefined4 *)(iVar5 + 0x20);
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_UnScheduleShow__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar3,uVar8,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar5 + 0x20) = piVar6, *piVar6 != iVar7)) {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  iVar7 = **(int **)(param1 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar3 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_EndlessPaymentOptionsReceivedEventHandler__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar3,uVar8,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar6) && (*(int **)(iVar5 + 0x1c) = piVar6, *piVar6 == iVar7)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar6,iVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0B")]
		[Address(RVA = "0xB7F4", Offset = "0xB7F4", VA = "0xB7F4", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__Init
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a742 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_CheckFreeOption__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_EndlessPaymentOptionsReceivedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_EndlessPaymentOptionsListWindow___
		              );
		    DAT_ram_00a5a742 = '\x01';
		  }
		  iVar7 = **(int **)(param1 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar7 + 0x114));
		  uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_EndlessPaymentOptionsReceivedEventHandler__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar7)) {
		    System_Activator__CreateInstance(piVar4,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = **(int **)(param1 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x104));
		  uVar3 = Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__EndlessPaymentOptionsReceivedEventHandler
		                    (param1,iVar2);
		  *(undefined4 *)(iVar7 + 0x3c) = uVar3;
		  iVar7 = **(int **)(param1 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar7 + 0x10);
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x208);
		        goto code_r0x81264bd4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x81264bd4:
		  uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  iVar7 = **(int **)(param1 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  local_4 = *(undefined4 *)(iVar7 + 0x3c);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		  uVar6 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (uVar6,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_CheckFreeOption__
		             ,0);
		  *(undefined4 *)(iVar7 + 0x10) = uVar6;
		  UI_Windows_PopupController__HasOpenWindow_object_
		            (uVar3,&local_4,iVar7,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_EndlessPaymentOptionsListWindow___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0xB7F5", Offset = "0xB7F5", VA = "0xB7F5")]
		private void EndlessPaymentOptionsReceivedEventHandler()
		{
		/* --- GHIDRA: EndlessPaymentOptionsReceivedEventHandler ---
		int Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__EndlessPaymentOptionsReceivedEventHandler
		              (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  float fVar2;
		  undefined8 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a743 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_ShowEndlessPaymentOptionsListWindowScheduled__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22938);
		    DAT_ram_00a5a743 = '\x01';
		  }
		  iVar3 = **(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                    (CONCAT44(in_register_20000004,*(int **)(param1 + 0x14)),
		                     *(undefined4 *)(iVar3 + 0x104));
		  uVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionListData___ctor(uVar1,0);
		  param1_00 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar1,StringLiteral_22938,0);
		  iVar3 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(iVar3,2,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar2 = func_ii_7331(param1_00,0);
		  *(float *)(iVar3 + 0xc) = fVar2;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_ShowEndlessPaymentOptionsListWindowScheduled__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = 0x7fffffff;
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  return iVar3;
		}
		*/

		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0xB7F6", Offset = "0xB7F6", VA = "0xB7F6")]
		private PopupScheduleManager.Args GetArgs()
		{
		/* --- GHIDRA: GetArgs ---
		int Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__GetArgs
		              (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_IsAvail
		                    (param1_00,0);
		  if (iVar1 == 0) {
		    Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__CheckFreeOption
		              (param1,param1);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0xB7F7", Offset = "0xB7F7", VA = "0xB7F7")]
		private bool CheckFreeOption()
		{
		/* --- GHIDRA: CheckFreeOption ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__CheckFreeOption
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a744 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_UnScheduleShow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a744 = '\x01';
		  }
		  iVar6 = **(int **)(param1 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar6 + 0x114));
		  param1_00 = *(undefined4 *)(iVar2 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_UnScheduleShow__
		             ,0);
		  piVar4 = (int *)func_ii_7048(param1_00,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar6)) {
		    System_Activator__CreateInstance(piVar4,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param1 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar6 + 0x10);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x208);
		        goto code_r0x81264ec3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x81264ec3:
		  uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  iVar6 = **(int **)(param1 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  local_4 = *(undefined4 *)(iVar6 + 0x3c);
		  Core_Gameplay_Managers_PopupScheduleManager__OpenFirstAvailableWindow(uVar3,&local_4,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0xB7F8", Offset = "0xB7F8", VA = "0xB7F8")]
		private void UnScheduleShow()
		{
		/* --- GHIDRA: UnScheduleShow ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__UnScheduleShow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param2_00;
		  
		  piVar2 = *(int **)(param1 + 0x14);
		  if (piVar2 == (int *)0x0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    param2_00 = *(undefined4 *)(iVar1 + 0x28);
		  }
		  Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__ShowEndlessPaymentOptionsListWindowScheduled
		            (param1,param2_00,8,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D10")]
		[Address(RVA = "0xB7F9", Offset = "0xB7F9", VA = "0xB7F9")]
		private void ShowEndlessPaymentOptionsListWindowScheduled()
		{
		/* --- GHIDRA: ShowEndlessPaymentOptionsListWindowScheduled ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__ShowEndlessPaymentOptionsListWindowScheduled
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  undefined4 param3_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a745 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12615);
		    DAT_ram_00a5a745 = '\x01';
		  }
		  iVar4 = **(int **)(param1 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar4 + 0x104));
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8126501d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126501d:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8126509f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8126509f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3_00 = *(undefined4 *)(param1 + 0x14);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs_TypeInfo
		                        );
		  Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow___ctor
		            (param1_01,param2,param3_00,param3,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12615,param1_01,
		             Method_UI_Windows_PopupController_Show_EndlessPaymentOptionsListWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D11")]
		[Address(RVA = "0xB7FA", Offset = "0xB7FA", VA = "0xB7FA")]
		private void ShowEndlessPaymentOptionsListWindow(EndlessPaymentOptionListData listData, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		/* --- GHIDRA: ShowEndlessPaymentOptionsListWindow ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__ShowEndlessPaymentOptionsListWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a746 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_HandleControllerInitEvent__
		              );
		    DAT_ram_00a5a746 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_HandleControllerInitEvent__
		             ,0);
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

		// Token: 0x06006D12 RID: 27922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0xB7FB", Offset = "0xB7FB", VA = "0xB7FB")]
		private void HandleControllerInitEvent()
		{
		/* --- GHIDRA: HandleControllerInitEvent ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__HandleControllerInitEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x10) = 0;
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D13")]
		[Address(RVA = "0xB7FC", Offset = "0xB7FC", VA = "0xB7FC", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__Deinit
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a747 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3878);
		    DAT_ram_00a5a747 = '\x01';
		  }
		  return StringLiteral_3878;
		}
		*/

		}

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x10")]
		private IGame _game;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x14")]
		[CanBeNull]
		public EndlessPaymentOptionsListController Controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a73d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a73d = '\x01';
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
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a73e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a73e = '\x01';
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
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a73f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a73f = '\x01';
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
		void Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a740 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a740 = '\x01';
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
