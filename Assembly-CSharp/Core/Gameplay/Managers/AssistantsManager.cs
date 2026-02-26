using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001141 RID: 4417
	[Token(Token = "0x2001141")]
	public class AssistantsManager : IGameManager, IBaseManager
	{
		// Token: 0x1400025E RID: 606
		// (add) Token: 0x060067A8 RID: 26536 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067A9 RID: 26537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067A8")]
			[Address(RVA = "0xB2D4", Offset = "0xB2D4", VA = "0xB2D4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067A9")]
			[Address(RVA = "0xB2D5", Offset = "0xB2D5", VA = "0xB2D5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025F RID: 607
		// (add) Token: 0x060067AA RID: 26538 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067AB RID: 26539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067AA")]
			[Address(RVA = "0xB2D6", Offset = "0xB2D6", VA = "0xB2D6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067AB")]
			[Address(RVA = "0xB2D7", Offset = "0xB2D7", VA = "0xB2D7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001539")]
		public AssistantsController Controller
		{
			[Token(Token = "0x60067AC")]
			[Address(RVA = "0xB2D8", Offset = "0xB2D8", VA = "0xB2D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067AD")]
			[Address(RVA = "0xB2D9", Offset = "0xB2D9", VA = "0xB2D9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AE")]
		[Address(RVA = "0xB2DA", Offset = "0xB2DA", VA = "0xB2DA", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_AssistantsManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a993 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__)
		    ;
		    DAT_ram_00a5a993 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__,0);
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
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AF")]
		[Address(RVA = "0xB2DB", Offset = "0xB2DB", VA = "0xB2DB")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Core_Gameplay_Managers_AssistantsManager__HandleInitEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a994 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BaseAssistant__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BaseAssistant__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BaseAssistant__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseAssistant__GetEnumerator__);
		    DAT_ram_00a5a994 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar4 = **(int **)(param1 + 0x10);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0x104));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(iVar4 + 0x14),
		             Method_System_Collections_Generic_List_BaseAssistant__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BaseAssistant__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812a03f0;
		    }
		    if (iVar1 == 0) goto code_r0x812a0446;
		    DAT_ram_009d3e38 = 0;
		    piVar3 = local_8._4_4_;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x4f,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*(undefined4 *)(iVar4 + 0xe8),piVar3,*(undefined4 *)(iVar4 + 0xec));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812a03f0:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x812a0446:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = **(int **)(param1 + 0x10);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                        (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0x114));
		      param1_00 = *(undefined4 *)(iVar1 + 8);
		      uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar2,param1,Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__,0);
		      piVar3 = (int *)func_ii_7048(param1_00,uVar2,0);
		      iVar4 = System_Action_TypeInfo;
		      if (piVar3 == (int *)0x0) {
		        *(undefined4 *)(iVar1 + 8) = 0;
		      }
		      else if ((System_Action_TypeInfo != *piVar3) ||
		              (*(int **)(iVar1 + 8) = piVar3, *piVar3 != iVar4)) {
		        System_Activator__CreateInstance(piVar3,iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		      iVar4 = **(int **)(param1 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xec));
		      *(undefined4 *)(param1 + 0x10) = 0;
		      iVar4 = *(int *)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x50,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0xB2DC", Offset = "0xB2DC", VA = "0xB2DC", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_AssistantsManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a995 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3350);
		    DAT_ram_00a5a995 = '\x01';
		  }
		  return StringLiteral_3350;
		}
		*/

		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060067B1 RID: 26545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153A")]
		public string Name
		{
			[Token(Token = "0x60067B1")]
			[Address(RVA = "0xB2DD", Offset = "0xB2DD", VA = "0xB2DD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B2")]
		[Address(RVA = "0xB2DE", Offset = "0xB2DE", VA = "0xB2DE")]
		public AssistantsManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_AssistantsManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a996 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3779);
		    DAT_ram_00a5a996 = '\x01';
		  }
		  return StringLiteral_3779;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_AssistantsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a98f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a98f = '\x01';
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
		void Core_Gameplay_Managers_AssistantsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a990 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a990 = '\x01';
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
		void Core_Gameplay_Managers_AssistantsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a991 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a991 = '\x01';
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


		/* --- GHIDRA: set_Controller ---
		void Core_Gameplay_Managers_AssistantsManager__set_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param3;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a992 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Control_AssistantsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_AssistantsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Model_AssistantsListModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Manufacture_ManufactureAssistant_var);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a992 = '\x01';
		  }
		  param3 = unnamed_function_1417(Gameplay_Assistants_AssistantsEvents_TypeInfo);
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type___ctor__
		            );
		  uVar3 = Gameplay_Assistants_Manufacture_ManufactureAssistant_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  func_ii_10812(uVar2,1,uVar3,
		                Method_System_Collections_Generic_Dictionary_AssistantsDic_Types_Assistants__Type__Add__
		               );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8129ffee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129ffee:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar7 + 0x234);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x812a00a4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a00a4:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  param1_00 = unnamed_function_1417(Gameplay_Assistants_Model_AssistantsListModel_TypeInfo);
		  Gameplay_Assistants_Model_AssistantsListModel__Dispose(param1_00,uVar2,uVar3,uVar5,0);
		  iVar7 = unnamed_function_1417(Gameplay_Assistants_Control_AssistantsController_TypeInfo);
		  Gameplay_Assistants_Control_AssistantsController__Dispose(iVar7,param1_00,param3,0);
		  *(int *)(param1 + 0x10) = iVar7;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(iVar7 + 0x18) = uVar3;
		  uVar2 = *(undefined4 *)(param3 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_AssistantsManager_HandleInitEvent__,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar3,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(param3 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(param3 + 8) = piVar6, *piVar6 != iVar7)
		          ) {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

}
