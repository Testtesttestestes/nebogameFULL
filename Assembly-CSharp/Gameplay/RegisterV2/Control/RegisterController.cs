using System;
using Core.Gameplay.Managers;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using ServicesNamespace;
using Utils;

namespace Gameplay.RegisterV2.Control
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public class RegisterController : AbstractController<RegisterModel, RegisterEvents>, IRegistration
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x72C3", Offset = "0x72C3", VA = "0x72C3")]
		public RegisterController(RegisterModel model, RegisterEvents events)
		{
		/* --- GHIDRA: <HandleRun>b__2_0 ---
		void Gameplay_RegisterV2_Control_RegisterController___HandleRun_b__2_0
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_RegisterV2_Control_RegisterController__PrepareData(param1,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_Control_RegisterController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58388 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterController__HandleRun_b__2_0__);
		    DAT_ram_00a58388 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  param1_01 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterController__HandleRun_b__2_0__,0);
		  Core_Application_Managers_Connection_ConnectionManager__ReConnect(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x72C4", Offset = "0x72C4", VA = "0x72C4", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_RegisterV2_Control_RegisterController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param2_00;
		  undefined4 uVar8;
		  int *piVar9;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58389 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_AprDic___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CultDic___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CultDic__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CultDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterController__PrepareData_b__3_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5053);
		    DAT_ram_00a58389 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_AprDic___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__List_AprDic____ctor__);
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ed85a0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed85a0:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(iVar7 + 0x30),Method_System_Linq_Enumerable_ToList_CultDic___);
		  *(undefined4 *)(iVar2 + 0x14) = uVar3;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = UnityEngine_Random__Range(0,*(undefined4 *)(*(int *)(iVar7 + 0x14) + 0xc),0);
		  iVar7 = System_Linq_Enumerable__ToList_object_
		                    (uVar8,uVar3,Method_System_Collections_Generic_List_CultDic__get_Item__);
		  *(undefined4 *)(iVar2 + 0x24) = *(undefined4 *)(iVar7 + 0xc);
		  iVar2 = 0;
		  do {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		          puVar4 = (uint *)(piVar9[1] * 8 + iVar7 + 0x178);
		          goto code_r0x80ed86ca;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed86ca:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    if (*(int *)(*(int *)(iVar7 + 0x1c0) + 0xc) <= iVar2) break;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		          puVar4 = (uint *)(piVar9[1] * 8 + iVar7 + 0x178);
		          goto code_r0x80ed8782;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed8782:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar7 + 0x1c0),iVar2,
		                       Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Item__
		                      );
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		          puVar4 = (uint *)(piVar9[1] * 8 + iVar5 + 0x178);
		          goto code_r0x80ed8842;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed8842:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar5 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                      (uVar3,*(undefined4 *)(iVar7 + 0xc),0);
		    if (iVar5 == 0) {
		      local_4 = *(undefined4 *)(iVar7 + 0xc);
		      uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		      uVar3 = func_ii_4419(StringLiteral_5053,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar3,0);
		    }
		    else {
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar7 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar5 + 0x14),
		                         Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__
		                        );
		      if (iVar7 == 0) {
		code_r0x80ed8914:
		        iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        uVar8 = *(undefined4 *)(iVar7 + 0x18);
		        param2_00 = *(undefined4 *)(iVar5 + 0x14);
		        uVar3 = unnamed_function_1417(System_Collections_Generic_List_AprDic__TypeInfo);
		        GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                  (uVar3,Method_System_Collections_Generic_List_AprDic___ctor__);
		        System_Collections_Generic_Dictionary_uint__object___get_Item
		                  (uVar8,param2_00,uVar3,
		                   Method_System_Collections_Generic_Dictionary_uint__List_AprDic___set_Item__);
		      }
		      else {
		        iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar7 = System_Collections_Generic_List_object___get_Item
		                          (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar5 + 0x14),
		                           Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__
		                          );
		        if (iVar7 == 0) goto code_r0x80ed8914;
		      }
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar5 + 0x14),
		                             Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__
		                            );
		      iVar7 = Method_System_Collections_Generic_List_AprDic__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar1 = *(uint *)(param1_00 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = iVar5;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    iVar2 = iVar2 + 1;
		  } while( true );
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = System_Uri___ctor(0);
		  piVar6 = *(int **)(*(int *)(iVar7 + 0x54) + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x80ed8a83;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,1)
		  ;
		code_r0x80ed8a83:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		  uVar3 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar8,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(iVar2 + 0x20) = uVar8;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58384 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		    DAT_ram_00a58384 = '\x01';
		  }
		  iVar5 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar7 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__)
		  ;
		  if (iVar5 != 0) {
		    uVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar7 + 0x24),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		  }
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58384 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		    DAT_ram_00a58384 = '\x01';
		  }
		  UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		            (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar7 + 0x24),
		             Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		  iVar7 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar7 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		  uVar8 = UnityEngine_Random__Range(0,*(undefined4 *)(iVar7 + 0xc),0);
		  uVar3 = System_Linq_Enumerable__ToList_object_
		                    (uVar3,uVar8,Method_System_Collections_Generic_List_AprDic__get_Item__);
		  *(undefined4 *)(iVar2 + 0x28) = uVar3;
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterController__PrepareData_b__3_0__,0);
		  Gameplay_RegisterV2_Control_RegisterController__OnNickGenerated(param1,0,uVar3,uVar3);
		  return;
		}
		*/

		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x72C5", Offset = "0x72C5", VA = "0x72C5")]
		private void PrepareData()
		{
		/* --- GHIDRA: PrepareData ---
		void Gameplay_RegisterV2_Control_RegisterController__PrepareData
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a5838a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a5838a = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (param1_00[3],Method_System_Linq_Enumerable_ToList_string___);
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(iVar3 + 0x20),0,
		                     Method_System_Collections_Generic_List_string__get_Item__);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x72C6", Offset = "0x72C6", VA = "0x72C6")]
		private void OnNickGenerated(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnNickGenerated ---
		void Gameplay_RegisterV2_Control_RegisterController__OnNickGenerated
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5838b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass5_0__RequestPossibleNicks_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass5_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5838b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass5_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = StringLiteral_5;
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  if (param2 == 0) {
		    param2 = iVar1;
		  }
		  piVar2 = (int *)Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                            (*(undefined4 *)
		                              (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		  uVar4 = ServicesNamespace_Auth2Service__ServerEventHandler(uVar4,param2,uVar3,0);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar4,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param2_00,
		             Method_Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass5_0__RequestPossibleNicks_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar4,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002168")]
		[Address(RVA = "0x72C7", Offset = "0x72C7", VA = "0x72C7")]
		private void RequestPossibleNicks(string nick, Action<OpToken<IMessage, object>> callback)
		{
		/* --- GHIDRA: RequestPossibleNicks ---
		void Gameplay_RegisterV2_Control_RegisterController__RequestPossibleNicks
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5838c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterController_OnNickGenerated__);
		    DAT_ram_00a5838c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterController_OnNickGenerated__,0);
		  Gameplay_RegisterV2_Control_RegisterController__OnNickGenerated(param1,0,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002169")]
		[Address(RVA = "0x72C8", Offset = "0x72C8", VA = "0x72C8")]
		public void GenerateNick()
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x72C9", Offset = "0x72C9", VA = "0x72C9")]
		public void SetNick(string nick)
		{
		/* --- GHIDRA: SetNick ---
		void Gameplay_RegisterV2_Control_RegisterController__SetNick(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param4;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5838d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13543);
		    DAT_ram_00a5838d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Gameplay_RegisterV2_Control_RegisterController__Register
		                    (param1,uVar2,*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0xc),param1);
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = *(undefined4 *)(iVar1 + 0x1c);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_4 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0xc);
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_5 = *(undefined1 *)(iVar1 + 0x30);
		    param4 = func_ii_1081(DAT_ram_00a66944,&local_5);
		    uVar2 = func_ii_8529(StringLiteral_13543,param2_00,uVar2,param4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216B")]
		[Address(RVA = "0x72CA", Offset = "0x72CA", VA = "0x72CA")]
		public void Register()
		{
		/* --- GHIDRA: Register ---
		undefined4
		Gameplay_RegisterV2_Control_RegisterController__Register
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  char cVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5838e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_LoggedManager_RegisterCallbackInvoker__RegisterCmd_Types_Ans__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_IRegistrationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterController_OnRegisterResult__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_AuthScope_RegistrationRequestEventArgs_TypeInfo);
		    DAT_ram_00a5838e = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  cVar1 = *(char *)(iVar3 + 0x30);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (cVar1 != '\0') {
		    return (uint)(*(char *)(iVar3 + 0x30) == '\0');
		  }
		  *(undefined1 *)(iVar3 + 0x30) = 1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  piVar6 = *(int **)(iVar3 + 0x34);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80ed90c5;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ed90c5:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar2 = 0;
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x80ed9147;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,8);
		code_r0x80ed9147:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 8) + 0x10);
		  if (iVar3 != 0) {
		    uVar5 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_AuthScope_RegistrationRequestEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,uVar5,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar3 + 0x38);
		  uVar2 = 0;
		  uVar5 = unnamed_function_1417
		                    (
		                    System_Action_LoggedManager_RegisterCallbackInvoker__RegisterCmd_Types_Ans__TypeInfo
		                    );
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar5,param1,Method_Gameplay_RegisterV2_Control_RegisterController_OnRegisterResult__,0
		            );
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_IRegistrationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ed9274;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_IRegistrationProvider_TypeInfo,0);
		code_r0x80ed9274:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,param2,param3,uVar5,puVar4[1]);
		  return 1;
		}
		*/

		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x600216C")]
		[Address(RVA = "0x72CB", Offset = "0x72CB", VA = "0x72CB")]
		private bool TryRequestRegisterProcessing(string nick, uint aprId)
		{
		/* --- GHIDRA: TryRequestRegisterProcessing ---
		void Gameplay_RegisterV2_Control_RegisterController__TryRequestRegisterProcessing
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x30) = 0;
		  Gameplay_RegisterV2_Control_RegisterController__OnRegisterResult
		            (param1,*(undefined4 *)(param3 + 0xc),param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216D")]
		[Address(RVA = "0x72CC", Offset = "0x72CC", VA = "0x72CC")]
		private void OnRegisterResult(LoggedManager.RegisterCallbackInvoker invoker, RegisterCmd.Types.Ans msg)
		{
		/* --- GHIDRA: OnRegisterResult ---
		void Gameplay_RegisterV2_Control_RegisterController__OnRegisterResult
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5838f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13130);
		    DAT_ram_00a5838f = '\x01';
		  }
		  if (param2 == 0) {
		    Gameplay_RegisterV2_Control_RegisterController__HandleInvalidNickError(param1,0);
		    return;
		  }
		  if (param2 != 1) {
		    if (param2 == 2) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13130,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,2,param3_00,0);
		    }
		    else if (param2 == 0x66) goto code_r0x80ed92fe;
		    return;
		  }
		code_r0x80ed92fe:
		  Gameplay_RegisterV2_Control_RegisterController__HandleRegisterResult(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x72CD", Offset = "0x72CD", VA = "0x72CD", Slot = "13")]
		public void HandleRegisterResult(RegisterCmd.Types.Result result)
		{
		/* --- GHIDRA: HandleRegisterResult ---
		void Gameplay_RegisterV2_Control_RegisterController__HandleRegisterResult
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58390 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass12_0__HandleInvalidNickError_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass12_0_TypeInfo);
		    DAT_ram_00a58390 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass12_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_01 = *(undefined4 *)(iVar1 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_RegisterV2_Control_RegisterController___c__DisplayClass12_0__HandleInvalidNickError_b__0__
		             ,0);
		  Gameplay_RegisterV2_Control_RegisterController__OnNickGenerated(param1,param2_01,param1_00,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x72CE", Offset = "0x72CE", VA = "0x72CE")]
		private void HandleInvalidNickError(RegisterCmd.Types.Result result)
		{
		/* --- GHIDRA: HandleInvalidNickError ---
		void Gameplay_RegisterV2_Control_RegisterController__HandleInvalidNickError
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58391 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameResolver_TypeInfo);
		    DAT_ram_00a58391 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x18);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x3c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGameResolver_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ed945e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGameResolver_TypeInfo,0);
		code_r0x80ed945e:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x72CF", Offset = "0x72CF", VA = "0x72CF", Slot = "14")]
		public void Complete()
		{
		/* --- GHIDRA: Complete ---
		void Gameplay_RegisterV2_Control_RegisterController__Complete(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58392 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RegisterModel__RegisterEvents__Dispose__);
		    DAT_ram_00a58392 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_RegisterModel__RegisterEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x72D0", Offset = "0x72D0", VA = "0x72D0", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_RegisterV2_Control_RegisterController__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_RegisterV2_Control_RegisterController__HandleRun(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x18")]
		private Auth2Service _authService;
	}
}
