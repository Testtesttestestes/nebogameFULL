using System;
using System.Runtime.CompilerServices;
using Gameplay.SpecialOffers.Controller;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117A RID: 4474
	[Token(Token = "0x200117A")]
	public class SpecialOffersManager : IGameManager, IBaseManager
	{
		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x060069E6 RID: 27110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015AB")]
		public string Name
		{
			[Token(Token = "0x60069E6")]
			[Address(RVA = "0xB506", Offset = "0xB506", VA = "0xB506", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A0 RID: 672
		// (add) Token: 0x060069E7 RID: 27111 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069E8 RID: 27112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069E7")]
			[Address(RVA = "0xB507", Offset = "0xB507", VA = "0xB507", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069E8")]
			[Address(RVA = "0xB508", Offset = "0xB508", VA = "0xB508", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A1 RID: 673
		// (add) Token: 0x060069E9 RID: 27113 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069EA RID: 27114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069E9")]
			[Address(RVA = "0xB509", Offset = "0xB509", VA = "0xB509", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069EA")]
			[Address(RVA = "0xB50A", Offset = "0xB50A", VA = "0xB50A", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AC")]
		public SpecialOffersController Controller
		{
			[Token(Token = "0x60069EB")]
			[Address(RVA = "0xB50B", Offset = "0xB50B", VA = "0xB50B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069EC")]
			[Address(RVA = "0xB50C", Offset = "0xB50C", VA = "0xB50C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AD")]
		public SpecialOffersEvents Events
		{
			[Token(Token = "0x60069ED")]
			[Address(RVA = "0xB50D", Offset = "0xB50D", VA = "0xB50D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069EE")]
			[Address(RVA = "0xB50E", Offset = "0xB50E", VA = "0xB50E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AE")]
		public SpecialOffersModel Model
		{
			[Token(Token = "0x60069EF")]
			[Address(RVA = "0xB50F", Offset = "0xB50F", VA = "0xB50F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069F0")]
			[Address(RVA = "0xB510", Offset = "0xB510", VA = "0xB510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F1")]
		[Address(RVA = "0xB511", Offset = "0xB511", VA = "0xB511")]
		public SpecialOffersManager(IGame game)
		{
		/* --- GHIDRA: <SpecialOffersRequestedEventHandler>b__24_0 ---
		void Core_Gameplay_Managers_SpecialOffersManager___SpecialOffersRequestedEventHandler_b__24_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6384e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6384e = '\x01';
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

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_SpecialOffersManager___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    piVar1 = *(int **)(param1 + 0x18);
		    iVar2 = *piVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))(piVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		    *(undefined8 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F2")]
		[Address(RVA = "0xB512", Offset = "0xB512", VA = "0xB512", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_SpecialOffersManager__Deinit(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a63849 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_SpecialOffersManager_SpecialOffersRequestedEventHandler__
		              );
		    DAT_ram_00a63849 = '\x01';
		  }
		  Core_Gameplay_Managers_SpecialOffersManager__ShowSpecialOffersWindow(param1,param1);
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_SpecialOffersManager_SpecialOffersRequestedEventHandler__
		             ,0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(iVar1 + 0x14) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F3")]
		[Address(RVA = "0xB513", Offset = "0xB513", VA = "0xB513", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_SpecialOffersManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  float fVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  undefined8 uVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  int local_4;
		  
		  if (DAT_ram_00a6384a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_SpecialOffersWindow___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_SpecialOffersManager_ShowSpecialOffersWindowScheduled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_SpecialOffersManager_SpecialOffersRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_SpecialOffersManager__SpecialOffersRequestedEventHandler_b__24_0__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27341);
		    DAT_ram_00a6384a = '\x01';
		  }
		  local_4 = 0;
		  iVar7 = *(int *)(param1 + 0x14);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_SpecialOffersManager_SpecialOffersRequestedEventHandler__
		             ,0);
		  piVar2 = (int *)func_ii_7048(uVar8,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(iVar7 + 0x14) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = Gameplay_SpecialOffers_View_Picker_BankOptionPickerOsaViewHolder___ctor
		                    (*(undefined4 *)(param1 + 0x18),0);
		  uVar6 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar1,StringLiteral_27341,0);
		  iVar3 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x14) = 2;
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar4 = func_ii_7331(uVar6,0);
		  *(float *)(iVar3 + 0xc) = fVar4;
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_SpecialOffersManager_ShowSpecialOffersWindowScheduled__,0
		            );
		  *(undefined4 *)(iVar3 + 8) = 0x7fffffff;
		  *(undefined4 *)(iVar3 + 0x10) = uVar8;
		  local_4 = iVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0x208);
		        goto code_r0x82308850;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x82308850:
		  uVar6 = CONCAT44(uVar1,piVar2);
		  uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(uVar6,puVar5[1]);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		  param1_00 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_SpecialOffersManager__SpecialOffersRequestedEventHandler_b__24_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = param1_00;
		  UI_Windows_PopupController__HasOpenWindow_object_
		            (uVar8,&local_4,iVar3,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_SpecialOffersWindow___
		            );
		  iVar3 = *(int *)(param1 + 8);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (CONCAT44(uVar1,*(undefined4 *)(iVar3 + 0x20)),param1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0xB514", Offset = "0xB514", VA = "0xB514")]
		private void SpecialOffersRequestedEventHandler()
		{
		/* --- GHIDRA: SpecialOffersRequestedEventHandler ---
		void Core_Gameplay_Managers_SpecialOffersManager__SpecialOffersRequestedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_SpecialOffersManager__ShowSpecialOffersWindowScheduled(param1,8,param1);
		  return;
		}
		*/

		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0xB515", Offset = "0xB515", VA = "0xB515")]
		public void ShowSpecialOffersWindowScheduled()
		{
		/* --- GHIDRA: ShowSpecialOffersWindowScheduled ---
		void Core_Gameplay_Managers_SpecialOffersManager__ShowSpecialOffersWindowScheduled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6384b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SpecialOffersWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_View_SpecialOffersWindow_SpecialOffersWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12671);
		    DAT_ram_00a6384b = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_SpecialOffers_View_SpecialOffersWindow_SpecialOffersWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12671,param1_00,
		             Method_UI_Windows_PopupController_Show_SpecialOffersWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F6")]
		[Address(RVA = "0xB516", Offset = "0xB516", VA = "0xB516")]
		public void ShowSpecialOffersWindow(WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		/* --- GHIDRA: ShowSpecialOffersWindow ---
		void Core_Gameplay_Managers_SpecialOffersManager__ShowSpecialOffersWindow
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a6384c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Events_SpecialOffersEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Model_SpecialOffersModel_TypeInfo);
		    DAT_ram_00a6384c = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0x1c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x823085b7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x823085b7:
		    uVar2 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (*(int *)(iVar5 + 0x14) != 0) {
		      uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		    }
		    uVar6 = *(undefined4 *)(param1 + 0x1c);
		    uVar4 = unnamed_function_1417(Gameplay_SpecialOffers_Model_SpecialOffersModel_TypeInfo);
		    Gameplay_SpecialOffers_Model_SpecialOffersModel___ctor(uVar4,uVar2,uVar6,0);
		    *(undefined4 *)(param1 + 0x18) = uVar4;
		    uVar2 = unnamed_function_1417(Gameplay_SpecialOffers_Events_SpecialOffersEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x14) = uVar2;
		    uVar6 = *(undefined4 *)(param1 + 0x18);
		    uVar4 = unnamed_function_1417
		                      (Gameplay_SpecialOffers_Controller_SpecialOffersController_TypeInfo);
		    Gameplay_SpecialOffers_Controller_OptionsOfferViewMediator___ctor(uVar4,uVar6,uVar2,0);
		    *(undefined4 *)(param1 + 0x10) = uVar4;
		    MVC_AbstractController__Dispose(uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0xB517", Offset = "0xB517", VA = "0xB517")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Core_Gameplay_Managers_SpecialOffersManager__SetupMVC(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    piVar1 = *(int **)(param1 + 0x18);
		    iVar2 = *piVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))(piVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		    *(undefined8 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0xB518", Offset = "0xB518", VA = "0xB518")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		uint Core_Gameplay_Managers_SpecialOffersManager__DestroyMVC(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a6384d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a6384d = '\x01';
		  }
		  iVar3 = **(int **)(param1 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf0) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar3 + 0xf4));
		  if (*(int *)(iVar3 + 0xc) < 1) {
		    uVar1 = 0;
		  }
		  else {
		    param1_01 = *(int **)(*(int *)(param1 + 0x18) + 0x10);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x298);
		          goto code_r0x82308a2e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x82308a2e:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    iVar4 = **(int **)(iVar3 + 0x14);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                          (*(int **)(iVar3 + 0x14),*(undefined4 *)(iVar4 + 0x104));
		    uVar1 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_LastList
		                      (param1_00,0);
		    uVar1 = uVar1 ^ 1;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x04003826 RID: 14374
		[Token(Token = "0x4003826")]
		[FieldOffset(Offset = "0x1C")]
		private IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_SpecialOffersManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63845 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63845 = '\x01';
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
		void Core_Gameplay_Managers_SpecialOffersManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63846 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63846 = '\x01';
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
		void Core_Gameplay_Managers_SpecialOffersManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63847 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63847 = '\x01';
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
		void Core_Gameplay_Managers_SpecialOffersManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63848 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63848 = '\x01';
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
