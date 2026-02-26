using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB0 RID: 3248
	[Token(Token = "0x2000CB0")]
	public class ManufactureAssistController : AbstractController<ManufactureAssistModel, ManufactureAssistantEvents>
	{
		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001019")]
		public ServicesService ServicesService
		{
			[Token(Token = "0x6004F13")]
			[Address(RVA = "0x9D3B", Offset = "0x9D3B", VA = "0x9D3B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F14")]
			[Address(RVA = "0x9D3C", Offset = "0x9D3C", VA = "0x9D3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101A")]
		public CraftService CraftService
		{
			[Token(Token = "0x6004F15")]
			[Address(RVA = "0x9D3D", Offset = "0x9D3D", VA = "0x9D3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F16")]
			[Address(RVA = "0x9D3E", Offset = "0x9D3E", VA = "0x9D3E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x9D3F", Offset = "0x9D3F", VA = "0x9D3F", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58986 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents___ctor__
		              );
		    DAT_ram_00a58986 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x9D40", Offset = "0x9D40", VA = "0x9D40")]
		public ManufactureAssistController(ManufactureAssistModel model, ManufactureAssistantEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a58987 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoManufactureGetInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleProgressEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnDropRemoveEvent__
		              );
		    DAT_ram_00a58987 = '\x01';
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Put(param1,0);
		  uVar5 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoManufactureGetInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleProgressEvent__
		             ,0);
		  ServicesNamespace_CraftService__remove_CraftSlotsChangedEvent(uVar5,uVar2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80f51584;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f51584:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar8 = **(int **)(iVar7 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar5 = *(undefined4 *)(iVar7 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnDropRemoveEvent__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80f516bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f516bc:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar8 = **(int **)(iVar7 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnArtifactDropRemoveEvent__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar7 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar8,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar8,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x9D41", Offset = "0x9D41", VA = "0x9D41", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a58988 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoManufactureGetInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleProgressEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnDropRemoveEvent__
		              );
		    DAT_ram_00a58988 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoManufactureGetInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleProgressEvent__
		             ,0);
		  ServicesNamespace_CraftService__add_ManufactureDismantleProgressEvent(uVar5,uVar2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80f51906;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f51906:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar8 = **(int **)(iVar7 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar5 = *(undefined4 *)(iVar7 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnDropRemoveEvent__
		             ,0);
		  iVar8 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar8,System_Action_DropTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80f51a3e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f51a3e:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar8 = **(int **)(iVar7 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleOnArtifactDropRemoveEvent__
		             ,0);
		  iVar8 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar7 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar8,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar8,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x9D42", Offset = "0x9D42", VA = "0x9D42", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleStop
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a58989 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoManufactureGetInfoAns_TypeInfo);
		    DAT_ram_00a58989 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoManufactureGetInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Craft_ProtoManufactureGetInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetStatus
		            (param1,param1_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x9D43", Offset = "0x9D43", VA = "0x9D43")]
		private void HandleManufactureGetInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleManufactureGetInfo ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureGetInfo
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5898a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoManufacturePutArtifactAns_TypeInfo);
		    DAT_ram_00a5898a = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoManufacturePutArtifactAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Craft_ProtoManufacturePutArtifactAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureTakeArtifact
		            (param1,param1_00[3],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x9D44", Offset = "0x9D44", VA = "0x9D44")]
		private void HandleManufacturePutArtifactService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleManufacturePutArtifactService ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufacturePutArtifactService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5898b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a5898b = '\x01';
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetStatus
		            (param1,param2,param1);
		  if (*(int *)(*(int *)(param2 + 0xc) + 0xc) != 5) {
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		    if (iVar2 == 0) {
		      return;
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0 < *(int *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x18) + 0xc)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x9D45", Offset = "0x9D45", VA = "0x9D45")]
		private void HandleManufactureDismantleProgressEvent(ProtoManufactureGetInfoAns msg)
		{
		/* --- GHIDRA: HandleManufactureDismantleProgressEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureDismantleProgressEvent
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  int param2_00;
		  longlong lVar5;
		  
		  if (DAT_ram_00a5898c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_AssistantStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    DAT_ram_00a5898c = '\x01';
		  }
		  if (param2 == 7) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(*(int *)(*(int *)(iVar1 + 0x24) + 0x18) + 0xc);
		    if (0 < iVar1) {
		      param2_00 = 0;
		      do {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x18),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__
		                          );
		        lVar5 = *(longlong *)(iVar2 + 0x10);
		        lVar4 = func_ii_7957(param3,0);
		        if (lVar5 == lVar4) {
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          Google_Protobuf_Collections_RepeatedField_object___Insert
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x18),param2_00,
		                     Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		          break;
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar1);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(*(int *)(*(int *)(iVar1 + 0x24) + 0x18) + 0xc) == 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = Protocol_Craft_ProtoManufactureGetInfoAns___ctor(*(undefined4 *)(iVar1 + 0x24),0);
		      uVar3 = unnamed_function_1417(Protocol_Common_AssistantStatus_TypeInfo);
		      *(undefined4 *)(iVar1 + 0xc) = uVar3;
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetStatus
		                (param1,iVar1,iVar1);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x9D46", Offset = "0x9D46", VA = "0x9D46")]
		private void HandleOnArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifact)
		{
		/* --- GHIDRA: HandleOnArtifactDropRemoveEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleOnArtifactDropRemoveEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5898d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_AssistantStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Clear__);
		    DAT_ram_00a5898d = '\x01';
		  }
		  if (param2 == 7) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Protocol_Craft_ProtoManufactureGetInfoAns___ctor(*(undefined4 *)(iVar1 + 0x24),0);
		    uVar2 = unnamed_function_1417(Protocol_Common_AssistantStatus_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType___CalculateSize
		              (*(undefined4 *)(iVar1 + 0x18),
		               Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Clear__);
		    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetStatus
		              (param1,iVar1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x9D47", Offset = "0x9D47", VA = "0x9D47")]
		private void HandleOnDropRemoveEvent(DropTypes dropType)
		{
		/* --- GHIDRA: HandleOnDropRemoveEvent ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleOnDropRemoveEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5898e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_ManufactureAssistScope_ManufactureAssistEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoManufactureDismantleAns_TypeInfo);
		    DAT_ram_00a5898e = '\x01';
		  }
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Craft_ProtoManufactureDismantleAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Craft_ProtoManufactureDismantleAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureTakeArtifact
		            (param1,piVar3[3],param2);
		  piVar3 = *(int **)(param2 + 0xc);
		  if (piVar3 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar3 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    puVar1 = (undefined4 *)func_ii_15774(piVar3);
		    param4 = *puVar1;
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x7c) + 8);
		    if (iVar2 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (
		                            Core_Events_Scopes_ManufactureAssistScope_ManufactureAssistEventArgs_TypeInfo
		                            );
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,param2_00,param3_00,param4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x9D48", Offset = "0x9D48", VA = "0x9D48")]
		private void HandleManufactureDismantleService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleManufactureDismantleService ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureDismantleService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5898f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoManufactureTakeArtifactAns_TypeInfo);
		    DAT_ram_00a5898f = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoManufactureTakeArtifactAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Craft_ProtoManufactureTakeArtifactAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureTakeArtifact
		            (param1,param1_00[3],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F21")]
		[Address(RVA = "0x9D49", Offset = "0x9D49", VA = "0x9D49")]
		private void HandleManufactureTakeArtifact(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleManufactureTakeArtifact ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureTakeArtifact
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  float param2_00;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  
		  if (DAT_ram_00a58990 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58990 = '\x01';
		  }
		  uVar5 = CONCAT44(in_register_20000004,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar5,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  iVar2 = Protocol_Common_AssistantStatus__Equals(*(undefined4 *)(iVar2 + 0x14),param2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar4,param1),*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar3 + 0x14) = param2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar3 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined8 *)(*(int *)(iVar3 + 0x14) + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar5,0);
		  uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar1,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x9D4A", Offset = "0x9D4A", VA = "0x9D4A")]
		private void SetStatus(AssistantStatus status)
		{
		/* --- GHIDRA: SetStatus ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetStatus
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a58991 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    DAT_ram_00a58991 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Protocol_Craft_ProtoManufactureGetInfoAns__Equals(param2,*(undefined4 *)(iVar2 + 0x24),0);
		  iVar6 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x104));
		  if (*(int *)(iVar3 + 0x24) != 0) {
		    iVar3 = *(int *)(param2 + 0x14);
		    if (*(int *)(iVar3 + 0xc) < 1) {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetInfo
		                (param1,0,0xffffffff,iVar6);
		    }
		    else {
		      iVar6 = 0;
		      do {
		        uVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar3,iVar6,
		                           Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__
		                          );
		        Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetInfo
		                  (param1,uVar5,0xffffffff,iVar6);
		        iVar6 = iVar6 + 1;
		        iVar3 = *(int *)(param2 + 0x14);
		      } while (iVar6 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar3 + 0x24) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80f51cdf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f51cdf:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  param1_01 = *(undefined4 *)(iVar3 + 0x10);
		  iVar6 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x104));
		  uVar5 = func_ii_6295(*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x18),
		                       Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__TryGetDrop(param1_01,7,uVar5,iVar6);
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__HandleManufactureTakeArtifact
		            (param1,*(undefined4 *)(param2 + 0xc),iVar6);
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x9D4B", Offset = "0x9D4B", VA = "0x9D4B")]
		private void SetInfo(ProtoManufactureGetInfoAns msg)
		{
		/* --- GHIDRA: SetInfo ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetInfo
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  undefined8 uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58992 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__set_Item__);
		    DAT_ram_00a58992 = '\x01';
		  }
		  local_8 = 0;
		  uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x14) + 0xc);
		  uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  if (param2 == 0) {
		    param3 = 0;
		    uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType___CalculateSize
		              (*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x14),
		               Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Clear__);
		    uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    uVar4 = 0;
		  }
		  else {
		    uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    param1_00 = *(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x14);
		    if (iVar2 < 1) {
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      func_ii_6441(param1_00,param2,
		                   Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Add__);
		      uVar4 = 0;
		    }
		    else {
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,0,
		                         Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		      local_8 = *(undefined8 *)(iVar3 + 0x10);
		      uVar5 = *(undefined8 *)(param2 + 0x10);
		      uVar4 = UnityEngine_Rendering_BatchPackedCullingViewID__GetHashCode(&local_8,uVar5,0);
		      uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      Google_Protobuf_Collections_RepeatedField_object___get_IsReadOnly
		                (*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x14),0,param2,
		                 Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__set_Item__);
		      uVar4 = uVar4 ^ 1;
		    }
		    if (param3 < 0) goto code_r0x80f51ef2;
		    uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  }
		  *(int *)(iVar3 + 0x1c) = param3;
		code_r0x80f51ef2:
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		  if ((uVar4 != 0) || (iVar2 != *(int *)(*(int *)(*(int *)(iVar3 + 0x24) + 0x14) + 0xc))) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x9D4C", Offset = "0x9D4C", VA = "0x9D4C")]
		private void SetDismantleSlot(ArtifactInfo artifactInfo, int fromSlotId = -1)
		{
		/* --- GHIDRA: SetDismantleSlot ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetDismantleSlot
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined8 param2_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a58993 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufacturePutArtifactService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    DAT_ram_00a58993 = '\x01';
		  }
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetInfo
		            (param1,*(undefined4 *)(param2 + 0x74),*(undefined4 *)(param2 + 0x7c),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80f5287b;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f5287b:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,CONCAT44(in_register_20000014,puVar1[1]));
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  uVar2 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar2,Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		  iVar3 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(param2 + 0x7c);
		  func_ii_6441(uVar2,iVar3,Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		            (uVar4,uVar2,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = func_ii_7957(param2,0);
		  uVar2 = ServicesNamespace_CraftService__ManufactureGetInfo(uVar2,param2_00,0);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufacturePutArtifactService__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar2,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F25")]
		[Address(RVA = "0x9D4D", Offset = "0x9D4D", VA = "0x9D4D")]
		private void Put(ArtifactData artifact)
		{
		/* --- GHIDRA: Put ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Put
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58994 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureGetInfo__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58994 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__RemoveUserSheme(*(undefined4 *)(param1 + 0x1c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureGetInfo__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F26")]
		[Address(RVA = "0x9D4E", Offset = "0x9D4E", VA = "0x9D4E")]
		public void RequestInfo()
		{
		/* --- GHIDRA: RequestInfo ---
		undefined4
		Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__RequestInfo
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int param1_01;
		  undefined4 *puVar5;
		  int param1_02;
		  uint uVar6;
		  int iVar7;
		  int local_4;
		  
		  if (DAT_ram_00a58995 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c__TryPut_b__24_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2492);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2689);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2488);
		    DAT_ram_00a58995 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58981 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    DAT_ram_00a58981 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x24) + 0x14);
		  if ((*(int *)(iVar1 + 0xc) < 1) ||
		     (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,0,
		                         Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__),
		     iVar1 == 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_4 = 0;
		    uVar2 = func_ii_7504(*(undefined4 *)(iVar1 + 8),0);
		    iVar1 = Core_Data_UserData__get_Accounts(uVar2,3,&local_4,0);
		    if ((iVar1 == 0) || (local_4 == 0)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = *(int **)(iVar1 + 0xc);
		      iVar1 = *param1_00;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar6 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8 + 4) * 8 + iVar1 + 0x1f8);
		            goto code_r0x80f52b54;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar6);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f52b54:
		      iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		      iVar7 = **(int **)(iVar1 + 0x14);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                        (*(int **)(iVar1 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		      uVar2 = *(undefined4 *)(iVar1 + 0x2c);
		      iVar1 = unnamed_function_1417
		                        (
		                        Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs_TypeInfo
		                        );
		      Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow___ctor(iVar1,uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_2488,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar1 + 0x18) = uVar2;
		      *(undefined4 *)(iVar1 + 0x1c) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		      param1_01 = *(int *)(iVar1 + 0x24);
		      iVar7 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                (iVar7,
		                 Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		                );
		      *(undefined4 *)(iVar7 + 0xc) = 2;
		      uVar2 = func_ii_7508(StringLiteral_2492,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar7 + 8) = uVar2;
		      iVar4 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		                        );
		      if (*(int *)(Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                  + 0x74) == 0) {
		        func_ii_306000(
		                      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                      );
		      }
		      puVar5 = *(undefined4 **)
		                (Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo +
		                0x5c);
		      param1_02 = puVar5[1];
		      if (param1_02 == 0) {
		        if (*(int *)(
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                        );
		          puVar5 = *(undefined4 **)
		                    (
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                    + 0x5c);
		        }
		        uVar2 = *puVar5;
		        param1_02 = unnamed_function_1417
		                              (
		                              UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__TypeInfo
		                              );
		        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		                  (param1_02,uVar2,
		                   Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c__TryPut_b__24_0__
		                   ,0);
		        *(int *)(*(int *)(
		                         Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                         + 0x5c) + 4) = param1_02;
		      }
		      *(int *)(iVar4 + 8) = param1_02;
		      *(int *)(iVar7 + 0x14) = iVar4;
		      iVar4 = 
		      Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___Add__
		      ;
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar6 = *(uint *)(param1_01 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		        *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = iVar7;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      }
		      Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow__OnShow(iVar1,0);
		      uVar2 = 0;
		    }
		    else {
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetDismantleSlot
		                (param1,param2,param1);
		      uVar2 = 1;
		    }
		  }
		  else {
		    iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_2689,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar1,0);
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x9D4F", Offset = "0x9D4F", VA = "0x9D4F")]
		public bool TryPut(ArtifactData artifact)
		{
		/* --- GHIDRA: TryPut ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__TryPut
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 param2_00;
		  int param1_02;
		  
		  if (DAT_ram_00a58996 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureTakeArtifact__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58996 = '\x01';
		  }
		  param1_02 = param1[7];
		  param2_00 = func_ii_7957(param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param1_00 = ServicesNamespace_CraftService__ManufacturePutArtifact
		                        (param1_02,param2_00,*(undefined4 *)(iVar1 + 0x1c),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureTakeArtifact__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SetInfo
		            (param1,0,0xffffffff,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x9D50", Offset = "0x9D50", VA = "0x9D50")]
		public void Take(ArtifactData artifact)
		{
		/* --- GHIDRA: Take ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Take
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58997 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58997 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CraftService__ManufactureTakeArtifact
		                    (*(undefined4 *)(param1 + 0x1c),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_HandleManufactureDismantleService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F29")]
		[Address(RVA = "0x9D51", Offset = "0x9D51", VA = "0x9D51")]
		public void Dismantle(uint stackSize)
		{
		/* --- GHIDRA: Dismantle ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__Dismantle
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58998 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a58998 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0 < *(int *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x18) + 0xc)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x80f52f80;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f52f80:
		    iVar2 = (**(code **)((ulonglong)*param3 * 4))(param1_00,param3[1]);
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDrop
		              (*(undefined4 *)(iVar2 + 0x10),7,param3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2A")]
		[Address(RVA = "0x9D52", Offset = "0x9D52", VA = "0x9D52")]
		public void TakeAll()
		{
		/* --- GHIDRA: TakeAll ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__TakeAll
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58999 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a58999 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0 < *(int *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x18) + 0xc)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x80f5325b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f5325b:
		    iVar2 = (**(code **)((ulonglong)*param3 * 4))(param1_00,param3[1]);
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeAllDrop
		              (*(undefined4 *)(iVar2 + 0x10),7,param3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2B")]
		[Address(RVA = "0x9D53", Offset = "0x9D53", VA = "0x9D53")]
		public void SellAll()
		{
		/* --- GHIDRA: SellAll ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__SellAll(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5899a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo);
		    DAT_ram_00a5899a = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_Assistants_Manufacture_Control_ManufactureAssistController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CraftService ---
		void Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__set_CraftService
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58985 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents__Dispose__
		              );
		    DAT_ram_00a58985 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents__Dispose__
		            );
		  return;
		}
		*/

}
