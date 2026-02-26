using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Il2CppDummyDll;
using Preloading;
using UI;
using UnityEngine;

namespace Core
{
	// Token: 0x02000E56 RID: 3670
	[Token(Token = "0x2000E56")]
	public class AppLoader : MonoBehaviour
	{
		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060059D3 RID: 22995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700124B")]
		public AppCanvas AppCanvas
		{
			[Token(Token = "0x60059D3")]
			[Address(RVA = "0xA6FB", Offset = "0xA6FB", VA = "0xA6FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400021C RID: 540
		// (add) Token: 0x060059D4 RID: 22996 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059D5 RID: 22997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021C")]
		public event Action OnApplicationQuitEvent
		{
			[Token(Token = "0x60059D4")]
			[Address(RVA = "0xA6FC", Offset = "0xA6FC", VA = "0xA6FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059D5")]
			[Address(RVA = "0xA6FD", Offset = "0xA6FD", VA = "0xA6FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400021D RID: 541
		// (add) Token: 0x060059D6 RID: 22998 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059D7 RID: 22999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021D")]
		public event Action<bool> OnApplicationFocusEvent
		{
			[Token(Token = "0x60059D6")]
			[Address(RVA = "0xA6FE", Offset = "0xA6FE", VA = "0xA6FE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059D7")]
			[Address(RVA = "0xA6FF", Offset = "0xA6FF", VA = "0xA6FF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700124C")]
		public Preloader Preloader
		{
			[Token(Token = "0x60059D8")]
			[Address(RVA = "0xA700", Offset = "0xA700", VA = "0xA700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059D9")]
			[Address(RVA = "0xA701", Offset = "0xA701", VA = "0xA701")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DA")]
		[Address(RVA = "0xA702", Offset = "0xA702", VA = "0xA702")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_AppLoader__Awake(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c48 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IApp__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_AppLoader_InstanceOnInitCompleteEvent__);
		    DAT_ram_00a63c48 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  param1_00 = unnamed_function_1417(System_Action_IApp__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_AppLoader_InstanceOnInitCompleteEvent__,0);
		  Core_Application_App__remove_AppQuitEvent(uVar1,param1_00,0);
		  uVar1 = System_Uri___ctor(0);
		  Core_Application_App__SetAuth(uVar1,param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0xA703", Offset = "0xA703", VA = "0xA703")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Core_AppLoader__Start(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63c49 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IApp__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_AppLoader_InstanceOnInitCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Auth_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a63c49 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IApp__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_AppLoader_InstanceOnInitCompleteEvent__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x82372afa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Application_IApp_TypeInfo,1);
		code_r0x82372afa:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(Core_Gameplay_Auth_TypeInfo);
		  Core_Gameplay_Auth__Dispose(uVar2,param2,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x82372b8d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Application_IApp_TypeInfo,0x1a);
		code_r0x82372b8d:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0xA704", Offset = "0xA704", VA = "0xA704")]
		private void InstanceOnInitCompleteEvent(IApp app)
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0xA705", Offset = "0xA705", VA = "0xA705")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0xA706", Offset = "0xA706", VA = "0xA706")]
		private void OnApplicationFocus(bool focus)
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DF")]
		[Address(RVA = "0xA707", Offset = "0xA707", VA = "0xA707")]
		public AppLoader()
		{
		/* --- GHIDRA: .ctor ---
		void Core_AppLoader___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6054d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SystemLanguage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8434);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24729);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16536);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5996);
		    DAT_ram_00a6054d = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (DAT_ram_00a6054e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__IndexOf__);
		    DAT_ram_00a6054e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_01 = **(undefined4 **)(Core_GameLocalization_TypeInfo + 0x5c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x11c));
		  iVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (param1_01,uVar1,Method_System_Collections_Generic_List_string__IndexOf__);
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,6);
		  *(undefined4 *)(param1_00 + 0x10) = StringLiteral_8433;
		  uVar1 = func_ii_4419(StringLiteral_5996,param1,0);
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_16536;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x11c));
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  *(undefined4 *)(param1_00 + 0x20) = StringLiteral_1238;
		  local_c = CONCAT31(local_c._1_3_,-1 < iVar2);
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_c);
		  uVar1 = func_ii_4419(StringLiteral_24729,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  uVar1 = System_Single__ToString(param1_00,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  if (iVar2 < 0) {
		    local_8 = 0xaffffffff;
		    local_c = UnityEngine_SystemLanguage_TypeInfo;
		    uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__get_CurrentLanguage(uVar1,0);
		  }
		  else {
		    local_8 = 0x1effffffff;
		    local_c = UnityEngine_SystemLanguage_TypeInfo;
		    uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    I2_Loc_LocalizationManager__get_CurrentLanguage(uVar1,0);
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetWebServiceURL(0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_8434,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AppCanvas appCanvas;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AppCanvas ---
		void Core_AppLoader__get_AppCanvas(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63c43 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63c43 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnApplicationQuitEvent ---
		void Core_AppLoader__add_OnApplicationQuitEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63c44 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63c44 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnApplicationQuitEvent ---
		void Core_AppLoader__remove_OnApplicationQuitEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c45 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a63c45 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnApplicationFocusEvent ---
		void Core_AppLoader__add_OnApplicationFocusEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a63c46 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: set_Preloader ---
		void Core_AppLoader__set_Preloader(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_FindObjectOfType_Preloader___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c47 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = UnityEngine_Object__FindFirstObjectByType_object_
		                    (Method_UnityEngine_Object_FindObjectOfType_Preloader___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

}
