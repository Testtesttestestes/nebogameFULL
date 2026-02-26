using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Medals.Controller;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200116A RID: 4458
	[Token(Token = "0x200116A")]
	public class MedalsManager : IGameManager, IBaseManager
	{
		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158A")]
		public string Name
		{
			[Token(Token = "0x6006946")]
			[Address(RVA = "0xB46A", Offset = "0xB46A", VA = "0xB46A", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400028C RID: 652
		// (add) Token: 0x06006947 RID: 26951 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006948 RID: 26952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006947")]
			[Address(RVA = "0xB46B", Offset = "0xB46B", VA = "0xB46B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006948")]
			[Address(RVA = "0xB46C", Offset = "0xB46C", VA = "0xB46C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028D RID: 653
		// (add) Token: 0x06006949 RID: 26953 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600694A RID: 26954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006949")]
			[Address(RVA = "0xB46D", Offset = "0xB46D", VA = "0xB46D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600694A")]
			[Address(RVA = "0xB46E", Offset = "0xB46E", VA = "0xB46E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158B")]
		public MedalsController Controller
		{
			[Token(Token = "0x600694B")]
			[Address(RVA = "0xB46F", Offset = "0xB46F", VA = "0xB46F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x0600694C RID: 26956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158C")]
		public MedalsModel Model
		{
			[Token(Token = "0x600694C")]
			[Address(RVA = "0xB470", Offset = "0xB470", VA = "0xB470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x0600694D RID: 26957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158D")]
		public MedalsEvents Events
		{
			[Token(Token = "0x600694D")]
			[Address(RVA = "0xB471", Offset = "0xB471", VA = "0xB471")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x0600694E RID: 26958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600694F RID: 26959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700158E")]
		public MedalDicGroupStorage MedalDicGroupStorage
		{
			[Token(Token = "0x600694E")]
			[Address(RVA = "0xB472", Offset = "0xB472", VA = "0xB472")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600694F")]
			[Address(RVA = "0xB473", Offset = "0xB473", VA = "0xB473")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006950")]
		[Address(RVA = "0xB474", Offset = "0xB474", VA = "0xB474", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_MedalsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  int *param1_02;
		  undefined4 param5;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a637f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2017);
		    DAT_ram_00a637f0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    if (DAT_ram_00a637ea == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_10940);
		      DAT_ram_00a637ea = '\x01';
		    }
		    uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_10940,StringLiteral_2017,0)
		    ;
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar4,0);
		    return;
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82302e1b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82302e1b:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar4 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82302ed4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82302ed4:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_02,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  param5 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417(Gameplay_Medals_Model_MedalsModel_TypeInfo);
		  Gameplay_Medals_Model_MedalsModel__Dispose(param1_00,param1_01,uVar4,uVar2,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Medals_Controller_MedalsController_TypeInfo);
		  Gameplay_Medals_Controller_MedalsController__Dispose(uVar4,param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006951")]
		[Address(RVA = "0xB475", Offset = "0xB475", VA = "0xB475")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_MedalsManager__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006952")]
		[Address(RVA = "0xB476", Offset = "0xB476", VA = "0xB476")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void Core_Gameplay_Managers_MedalsManager__DestroyMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_MedalsManager_ControllerInitEvent__)
		    ;
		    DAT_ram_00a637f1 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_MedalsManager_ControllerInitEvent__,0);
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

		// Token: 0x06006953 RID: 26963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006953")]
		[Address(RVA = "0xB477", Offset = "0xB477", VA = "0xB477")]
		private void ControllerInitEvent()
		{
		/* --- GHIDRA: ControllerInitEvent ---
		void Core_Gameplay_Managers_MedalsManager__ControllerInitEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  Gameplay_Medals_Model_MedalDicGroupStorage__Init(*(undefined4 *)(param1 + 0x1c),0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006954")]
		[Address(RVA = "0xB478", Offset = "0xB478", VA = "0xB478", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_MedalsManager__Deinit(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a637f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    DAT_ram_00a637f2 = '\x01';
		  }
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x20),
		                         *(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		  Core_Gameplay_Managers_MedalsManager__ShowMedalInfoWindow
		            (param2,param2_00,*(undefined4 *)(param2 + 0x20),*(undefined4 *)(param1 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006955")]
		[Address(RVA = "0xB479", Offset = "0xB479", VA = "0xB479")]
		public void ShowOwnMedalInfoWindow(MedalDic medalDic)
		{
		/* --- GHIDRA: ShowOwnMedalInfoWindow ---
		void Core_Gameplay_Managers_MedalsManager__ShowOwnMedalInfoWindow
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a637f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalsModel_TypeInfo);
		    DAT_ram_00a637f3 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(Gameplay_Medals_Model_MedalsModel_TypeInfo);
		  Gameplay_Medals_Model_MedalsModel__Dispose(param1_00,uVar2,param4,param5,uVar1,0);
		  uVar1 = unnamed_function_1417(Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Medals_Controller_MedalsController_TypeInfo);
		  Gameplay_Medals_Controller_MedalsController__Dispose(uVar2,param1_00,uVar1,0);
		  Core_Gameplay_Managers_MedalsManager__ShowMedalInfoWindow(uVar1,param2,param3,uVar2,uVar1);
		  return;
		}
		*/

		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006956")]
		[Address(RVA = "0xB47A", Offset = "0xB47A", VA = "0xB47A")]
		public void ShowMedalInfoWindow(MedalData medalData, uint rankId, UserData user, UserData loggedUser)
		{
		/* --- GHIDRA: ShowMedalInfoWindow ---
		void Core_Gameplay_Managers_MedalsManager__ShowMedalInfoWindow(undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_MedalsManager__ShowMedalsWindow(0,0,0);
		  return;
		}
		*/

		/* --- GHIDRA: ShowMedalInfoWindow ---
		void Core_Gameplay_Managers_MedalsManager__ShowMedalInfoWindow(undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_MedalsManager__ShowMedalsWindow(0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006957")]
		[Address(RVA = "0xB47B", Offset = "0xB47B", VA = "0xB47B")]
		public void ShowMedalInfoWindow(MedalData medalData, uint rankId, MedalsController controller)
		{
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006958")]
		[Address(RVA = "0xB47C", Offset = "0xB47C", VA = "0xB47C")]
		public void ShowMedalsWindow()
		{
		/* --- GHIDRA: ShowMedalsWindow ---
		void Core_Gameplay_Managers_MedalsManager__ShowMedalsWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a637f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MedalsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12652);
		    DAT_ram_00a637f5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82303338;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82303338:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  uVar4 = System_Uri___ctor(0);
		  uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		  iVar5 = unnamed_function_1417(Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x20) = param2;
		  *(undefined4 *)(iVar5 + 0x18) = uVar2;
		  *(undefined4 *)(iVar5 + 0x1c) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar4,StringLiteral_12652,iVar5,Method_UI_Windows_PopupController_Show_MedalsWindow___)
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: ShowMedalsWindow ---
		void Core_Gameplay_Managers_MedalsManager__ShowMedalsWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a637f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MedalsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12652);
		    DAT_ram_00a637f5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82303338;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82303338:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  uVar4 = System_Uri___ctor(0);
		  uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		  iVar5 = unnamed_function_1417(Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x20) = param2;
		  *(undefined4 *)(iVar5 + 0x18) = uVar2;
		  *(undefined4 *)(iVar5 + 0x1c) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar4,StringLiteral_12652,iVar5,Method_UI_Windows_PopupController_Show_MedalsWindow___)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006959")]
		[Address(RVA = "0xB47D", Offset = "0xB47D", VA = "0xB47D")]
		public void ShowMedalsWindow(Predicate<MedalData> customFilter)
		{
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600695A")]
		[Address(RVA = "0xB47E", Offset = "0xB47E", VA = "0xB47E")]
		public MedalsManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_MedalsManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12467);
		    DAT_ram_00a637f6 = '\x01';
		  }
		  return StringLiteral_12467;
		}
		*/

		}

		// Token: 0x040037DF RID: 14303
		[Token(Token = "0x40037DF")]
		[FieldOffset(Offset = "0x10")]
		private MedalsController _controller;

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x14")]
		private MedalsModel _model;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[FieldOffset(Offset = "0x18")]
		private MedalsEvents _events;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_MedalsManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637eb = '\x01';
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
		void Core_Gameplay_Managers_MedalsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ec = '\x01';
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
		void Core_Gameplay_Managers_MedalsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ed = '\x01';
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
		void Core_Gameplay_Managers_MedalsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ee = '\x01';
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


		/* --- GHIDRA: set_MedalDicGroupStorage ---
		void Core_Gameplay_Managers_MedalsManager__set_MedalDicGroupStorage(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a637ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalDicGroupStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_MedalsManager_ControllerInitEvent__)
		    ;
		    DAT_ram_00a637ef = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x82302c12;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82302c12:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = unnamed_function_1417(Gameplay_Medals_Model_MedalDicGroupStorage_TypeInfo);
		  Gameplay_Medals_Model_MedalDicGroupStorage__set_MedalDicGroups(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  Core_Gameplay_Managers_MedalsManager__Init(param1,uVar3);
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_MedalsManager_ControllerInitEvent__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

}
