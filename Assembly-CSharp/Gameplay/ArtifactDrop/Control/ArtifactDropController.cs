using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Gameplay.Inventory.Controller.Middlewares;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.ArtifactDrop.Control
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public class ArtifactDropController : AbstractController<ArtifactDropModel, ArtifactDropEvents>, IArtifactDrop
	{
		// Token: 0x06004FAF RID: 20399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x9DC8", Offset = "0x9DC8", VA = "0x9DC8", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a589e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ArtifactDropModel__ArtifactDropEvents___ctor__);
		    DAT_ram_00a589e1 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param5,param6,
		             Method_MVC_AbstractController_ArtifactDropModel__ArtifactDropEvents___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x9DC9", Offset = "0x9DC9", VA = "0x9DC9")]
		public ArtifactDropController(MainService mainService, CraftService craftService, DismantleMiddleware dismantleMiddleware, ArtifactDropModel model, ArtifactDropEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)((int)param1 + 9) = 1;
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

		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x9DCA", Offset = "0x9DCA", VA = "0x9DCA", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (*(char *)((int)param1 + 9) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a589dd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Remove__
		                );
		      DAT_ram_00a589dd = '\x01';
		    }
		    local_4 = 0;
		    if (DAT_ram_00a589da == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                );
		      DAT_ram_00a589da = '\x01';
		    }
		    iVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                      (*(undefined4 *)(iVar1 + 0x14),param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                      );
		    if (iVar2 != 0) {
		      System_Collections_Generic_Dictionary_Int32Enum__object___OnDeserialization
		                (*(undefined4 *)(iVar1 + 0x14),param2,
		                 Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__Remove__
		                );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x9DCB", Offset = "0x9DCB", VA = "0x9DCB", Slot = "12")]
		public void Remove(DropTypes dropType)
		{
		/* --- GHIDRA: Remove ---
		undefined4
		Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Remove ---
		undefined4
		Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Remove ---
		undefined4
		Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x9DCC", Offset = "0x9DCC", VA = "0x9DCC", Slot = "13")]
		public void Remove(ArtifactData[] artifacts)
		{
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x9DCD", Offset = "0x9DCD", VA = "0x9DCD", Slot = "14")]
		public void Remove(ArtifactData artifact)
		{
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x9DCE", Offset = "0x9DCE", VA = "0x9DCE", Slot = "16")]
		public bool TryGetDrop(DropTypes dropType, out ArtifactDropModel.ArtifactDrop drop)
		{
		/* --- GHIDRA: TryGetDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__TryGetDrop
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a589e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetLastDropAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Add__);
		    DAT_ram_00a589e3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Main_ProtoGetLastDropAns_TypeInfo);
		  Protocol_Main_ProtoGetLastDropAns__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  iVar3 = *(int *)(param3 + 0xc);
		  if (0 < iVar3) {
		    do {
		      func_ii_6441(*(undefined4 *)(param1_00 + 0xc),*(undefined4 *)(param3 + iVar2 * 4 + 0x10),
		                   Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__Add__);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar3);
		  }
		  if (DAT_ram_00a589e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		    DAT_ram_00a589e4 = '\x01';
		  }
		  uVar1 = func_ii_6295(*(undefined4 *)(param1_00 + 0xc),
		                       Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		  iVar2 = Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		                    (param1,param2,uVar1,(uint)*(byte *)(param1_00 + 0x10),iVar2);
		  if (0 < *(int *)(*(int *)(iVar2 + 0xc) + 0xc)) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(uVar1,iVar2,iVar2);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x9DCF", Offset = "0x9DCF", VA = "0x9DCF", Slot = "15")]
		public void SetDrop(DropTypes dropType, params ArtifactInfo[] artifactInfo)
		{
		/* --- GHIDRA: SetDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__SetDrop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__SetDrop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x9DD0", Offset = "0x9DD0", VA = "0x9DD0")]
		private void SetDrop(ArtifactDropModel.ArtifactDrop drop)
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x9DD1", Offset = "0x9DD1", VA = "0x9DD1")]
		private ArtifactDropModel.ArtifactDrop CreateArtifactDrop(DropTypes dropType, ProtoGetLastDropAns msg)
		{
		/* --- GHIDRA: CreateArtifactDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int param1_01;
		  uint uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a589e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    DAT_ram_00a589e6 = '\x01';
		  }
		  iVar4 = *(int *)(param3 + 0xc);
		  if (0 < iVar4) {
		    do {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar5 = *param1_00;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar6 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar1 = (uint *)(piVar8[1] * 8 + iVar5 + 0x158);
		            goto code_r0x80f5b2a5;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		      }
		      puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f5b2a5:
		      uVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		      uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		      uVar7 = *(undefined4 *)(param3 + iVar2 * 4 + 0x10);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param2_00 = func_ii_8553(uVar3,uVar7,*(undefined4 *)(iVar5 + 8),0);
		      *(undefined4 *)(param2_00 + 0x80) = 2;
		      iVar5 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		      param1_01 = *(int *)(param2 + 0xc);
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar6 = *(uint *)(param1_01 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		        *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar4);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    uVar7 = *(undefined4 *)(param2 + 8);
		    uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar7,uVar3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: CreateArtifactDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int param1_01;
		  uint uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a589e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    DAT_ram_00a589e6 = '\x01';
		  }
		  iVar4 = *(int *)(param3 + 0xc);
		  if (0 < iVar4) {
		    do {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar5 = *param1_00;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar6 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar1 = (uint *)(piVar8[1] * 8 + iVar5 + 0x158);
		            goto code_r0x80f5b2a5;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		      }
		      puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f5b2a5:
		      uVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		      uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		      uVar7 = *(undefined4 *)(param3 + iVar2 * 4 + 0x10);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param2_00 = func_ii_8553(uVar3,uVar7,*(undefined4 *)(iVar5 + 8),0);
		      *(undefined4 *)(param2_00 + 0x80) = 2;
		      iVar5 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		      param1_01 = *(int *)(param2 + 0xc);
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar6 = *(uint *)(param1_01 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		        *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar4);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    uVar7 = *(undefined4 *)(param2 + 8);
		    uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (*(undefined4 *)(param2 + 0xc),
		                       Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar7,uVar3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x9DD2", Offset = "0x9DD2", VA = "0x9DD2")]
		private ArtifactDropModel.ArtifactDrop CreateArtifactDrop(DropTypes dropType, ArtifactInfo[] artifactInfos, bool limitExceeded)
		{
			return null;
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x9DD3", Offset = "0x9DD3", VA = "0x9DD3")]
		private void Add(ArtifactDropModel.ArtifactDrop drop, params ArtifactInfo[] artifactInfos)
		{
		/* --- GHIDRA: Add ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__Add
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__DismantleArtifact(param1,param2,param1);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),local_4,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x9DD4", Offset = "0x9DD4", VA = "0x9DD4")]
		public void RequestDrop(DropTypes dropType)
		{
		/* --- GHIDRA: RequestDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDrop
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param2_00 = Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		                        (param1,param2,param3,0,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(param1_00,param2_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: RequestDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDrop
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param2_00 = Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		                        (param1,param2,param3,0,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(param1_00,param2_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x9DD5", Offset = "0x9DD5", VA = "0x9DD5")]
		public void RequestDrop(DropTypes dropType, ArtifactInfo[] artifactInfos)
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x9DD6", Offset = "0x9DD6", VA = "0x9DD6")]
		public void TakeAllDrop(DropTypes dropType)
		{
		/* --- GHIDRA: TakeAllDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeAllDrop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a589e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass18_0__SellAllDrop_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass18_0_TypeInfo)
		    ;
		    DAT_ram_00a589e8 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass18_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(param2_00 + 0xc);
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),uVar2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(undefined4 *)(iVar1 + 8);
		    uVar2 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param2_00,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass18_0__SellAllDrop_b__0__
		               ,0);
		    param3_00 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                          (*(undefined4 *)(local_4 + 0xc),
		                           Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    UI_Windows_ConfirmSellUserArtifactWindow__HandleContent(param1_00,uVar2,param3_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x9DD7", Offset = "0x9DD7", VA = "0x9DD7")]
		public void SellAllDrop(DropTypes dropType)
		{
		/* --- GHIDRA: SellAllDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__SellAllDrop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a589e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactDrop_Control_ArtifactDropController__SellArtifacts_b__19_0__
		              );
		    DAT_ram_00a589e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_ArtifactData____TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController__SellArtifacts_b__19_0__,0)
		  ;
		  UI_Windows_ConfirmSellUserArtifactWindow__HandleContent(param1_01,param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x9DD8", Offset = "0x9DD8", VA = "0x9DD8")]
		public void SellArtifacts(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: SellArtifacts ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__SellArtifacts
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a589ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass20_0__TakeArtifacts_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass20_0_TypeInfo)
		    ;
		    DAT_ram_00a589ea = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass20_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop
		                    (uVar2,*(undefined4 *)(*(int *)(param2_00 + 0x10) + 0x10),param2_00 + 0xc,param1
		                    );
		  if (iVar3 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		          goto code_r0x80f5b6f8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f5b6f8:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		    uVar2 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),
		                       *(undefined4 *)(*(int *)(param2_00 + 0x10) + 0xc),3,
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                      );
		    param1_00 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param2_00,
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass20_0__TakeArtifacts_b__0__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar2,param1_00,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x9DD9", Offset = "0x9DD9", VA = "0x9DD9")]
		public void TakeArtifacts(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: TakeArtifacts ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeArtifacts
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a589eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass21_0__EquipArtifact_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass21_0_TypeInfo)
		    ;
		    DAT_ram_00a589eb = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass21_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80f5b856;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f5b856:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___StartResolveEmptySlotsProcess
		                        (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),
		                         *(undefined4 *)(param2_00 + 0xc),
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass21_0__EquipArtifact_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x9DDA", Offset = "0x9DDA", VA = "0x9DDA")]
		public void EquipArtifact(ArtifactData artifact)
		{
		/* --- GHIDRA: EquipArtifact ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__EquipArtifact
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestTakeArtifactFromDrop
		            (param1,param2,param3,param4,param4);
		  return;
		}
		*/

		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x9DDB", Offset = "0x9DDB", VA = "0x9DDB")]
		public void DismantleArtifact(ArtifactData artifact, bool sellDrop, bool wholeStack)
		{
		/* --- GHIDRA: DismantleArtifact ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__DismantleArtifact
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleGetLastDropService__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a589ec = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__InitComplete(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleGetLastDropService__,
		             0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(Protocol_Main_DropTypes_TypeInfo,&local_4);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x9DDC", Offset = "0x9DDC", VA = "0x9DDC")]
		public void RequestGetLastDrop(DropTypes dropType)
		{
		/* --- GHIDRA: RequestGetLastDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestGetLastDrop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleTakeAllDropService__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a589ed = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__SellArtifactFromDrop
		                    (*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleTakeAllDropService__,
		             0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(Protocol_Main_DropTypes_TypeInfo,&local_4);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x9DDD", Offset = "0x9DDD", VA = "0x9DDD")]
		private void RequestTakeAllDrop(DropTypes dropType)
		{
		/* --- GHIDRA: RequestTakeAllDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestTakeAllDrop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a589ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleSellAllFromDropService__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a589ee = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__TakeAllDrop(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleSellAllFromDropService__
		             ,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(Protocol_Main_DropTypes_TypeInfo,&local_4);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x9DDE", Offset = "0x9DDE", VA = "0x9DDE")]
		private void RequestSellAllFromDrop(DropTypes dropType)
		{
		/* --- GHIDRA: RequestSellAllFromDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestSellAllFromDrop
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a589ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleSellArtifactFromDropService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a589ef = '\x01';
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,*(undefined4 *)(param2 + 0xc));
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      uVar3 = func_ii_7957(*(undefined4 *)(param2 + iVar1 * 4 + 0x10),0);
		      *(undefined8 *)(param2_00 + iVar1 * 8 + 0x10) = uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  uVar2 = ServicesNamespace_MainService__TakeArtifactFromDrop
		                    (*(undefined4 *)(param1 + 0x18),param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleSellArtifactFromDropService__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x9DDF", Offset = "0x9DDF", VA = "0x9DDF")]
		private void RequestSellArtifactsFromDrop(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: RequestSellArtifactsFromDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestSellArtifactsFromDrop
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  int param4_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a589f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleTakeArtifactFromDropService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a589f0 = '\x01';
		  }
		  param4_00 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,*(undefined4 *)(param4 + 0xc));
		  if (0 < *(int *)(param4 + 0xc)) {
		    do {
		      uVar3 = func_ii_7957(*(undefined4 *)(param4 + iVar1 * 4 + 0x10),0);
		      *(undefined8 *)(param4_00 + iVar1 * 8 + 0x10) = uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param4 + 0xc));
		  }
		  uVar2 = ServicesNamespace_MainService__GetLastDrop
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,param4_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleTakeArtifactFromDropService__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,param4,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x9DE0", Offset = "0x9DE0", VA = "0x9DE0")]
		private void RequestTakeArtifactFromDrop(DropTypes dropType, uint startSlotId, params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: RequestTakeArtifactFromDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestTakeArtifactFromDrop
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  undefined8 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a589f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleDismantleArtifactFromDropService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a589f1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = func_ii_7957(param2,0);
		  uVar1 = ServicesNamespace_CraftService__GetUserSchemes(uVar1,param2_00,param3,param4,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController_HandleDismantleArtifactFromDropService__
		             ,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,param2,0);
		  *(char *)(param1_01 + 0xd) = (char)param4;
		  *(char *)(param1_01 + 0xc) = (char)param3;
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,param1_01,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x9DE1", Offset = "0x9DE1", VA = "0x9DE1")]
		private void RequestDismantleArtifactFromDrop(ArtifactData artifactData, bool sellDrop, bool wholeStack)
		{
		/* --- GHIDRA: RequestDismantleArtifactFromDrop ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDismantleArtifactFromDrop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int *piVar4;
		  uint uVar5;
		  int param1_01;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  undefined1 auStack_4 [4];
		  
		  if (DAT_ram_00a589f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCraftErrors__ExpectedRequirementsErrors__ExpectedTargetRequirementsErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoDismantleArtifactFromDropAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass29_0__HandleDismantleArtifactFromDropService_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass29_0_TypeInfo)
		    ;
		    DAT_ram_00a589f2 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass29_0_TypeInfo
		                        );
		  *(int **)(param2_00 + 8) = param1;
		  iVar3 = Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo;
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoDismantleArtifactFromDropAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Craft_ProtoDismantleArtifactFromDropAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar4 = *(int **)(param2 + 0xc);
		  if (piVar4 != (int *)0x0) {
		    uVar5 = (uint)*(byte *)(
		                           Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo
		                           + 0xb8);
		    if ((uVar5 <= *(byte *)(*piVar4 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar4 + 100) + (uVar5 - 1) * 4) ==
		        Gameplay_Inventory_Controller_InventoryController_DismantleArtifactVO_TypeInfo)) {
		      *(int **)(param2_00 + 0xc) = piVar4;
		      if ((uVar5 <= *(byte *)(*piVar4 + 0xb8)) &&
		         (*(int *)(*(int *)(*piVar4 + 100) + (uVar5 - 1) * 4) == iVar3)) goto code_r0x80f5bd7c;
		    }
		    System_Activator__CreateInstance(piVar4,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(undefined4 *)(param2_00 + 0xc) = 0;
		code_r0x80f5bd7c:
		  piVar4 = (int *)(param2_00 + 0xc);
		  param1_01 = param1_00[3];
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param2_00,
		             Method_Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass29_0__HandleDismantleArtifactFromDropService_b__0__
		             ,0);
		  uVar2 = unnamed_function_1417
		                    (Core_Errors_Expected_ExpectedCraftErrors_ExpectedCraftErrorsArgs_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = *(undefined4 *)(iVar3 + 8);
		  uVar7 = *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 8) + 0x20);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                    );
		  Core_Errors_Expected_ExpectedRequirementsErrors___ctor(uVar1,uVar6,uVar7,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar7 = *(undefined4 *)(iVar3 + 8);
		  param3_00 = *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 8) + 0x24);
		  uVar6 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                    );
		  Core_Errors_Expected_ExpectedRequirementsErrors___ctor(uVar6,uVar7,param3_00,0);
		  iVar3 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object__object_
		                    (param1_01,0,uVar2,uVar1,uVar6,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCraftErrors__ExpectedRequirementsErrors__ExpectedTargetRequirementsErrors___
		                    );
		  if (iVar3 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar3 + 0x18) = 0;
		    if ((param1_00[5] == 0) || (*(int *)(param1_00[5] + 0x10) == 0)) {
		      Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		                (param1,*(undefined4 *)(*piVar4 + 8),param1);
		    }
		    else {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop
		                        (uVar1,*(undefined4 *)(*piVar4 + 8),auStack_4,param1);
		      if (iVar3 != 0) {
		        uVar1 = *(undefined4 *)(*piVar4 + 8);
		        uVar2 = *(undefined4 *)(param1_00[5] + 0x10);
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Core_Data_ArtifactData__get_ArtifactInfo(uVar1,uVar2,*(undefined4 *)(iVar3 + 0x1c),0);
		      }
		    }
		    Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__Notify
		              (param1[8],*(undefined4 *)(*piVar4 + 8),3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x9DE2", Offset = "0x9DE2", VA = "0x9DE2")]
		private void HandleDismantleArtifactFromDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleDismantleArtifactFromDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleDismantleArtifactFromDropService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a589f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    DAT_ram_00a589f3 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_00[3]) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar2 + 0x18) = 1;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80f5c04b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f5c04b:
		    iVar2 = 0;
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar4 + 0x14),param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    param2_00 = Core_Data_ArtifactData___TypeInfo;
		    iVar4 = 0;
		    iVar5 = *(int *)(param2 + 0xc);
		    if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,Core_Data_ArtifactData___TypeInfo), iVar4 == 0))
		    {
		      System_Activator__CreateInstance(iVar5,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar5 = *(int *)(iVar4 + 0xc);
		    if (0 < iVar5) {
		      do {
		        Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		                  (param1,*(undefined4 *)(iVar4 + iVar2 * 4 + 0x10),iVar2);
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar5);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x9DE3", Offset = "0x9DE3", VA = "0x9DE3")]
		private void HandleTakeArtifactFromDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleTakeArtifactFromDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleTakeArtifactFromDropService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param3_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a589f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    DAT_ram_00a589f4 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x18) = 0;
		  param2_00 = Core_Data_ArtifactData___TypeInfo;
		  iVar1 = *(int *)(param2 + 0xc);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,Core_Data_ArtifactData___TypeInfo), iVar2 == 0)) {
		    System_Activator__CreateInstance(iVar1,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = *(int *)(iVar2 + 0xc);
		  if (0 < iVar1) {
		    param3_00 = 0;
		    do {
		      Gameplay_ArtifactDrop_Control_ArtifactDropController__Remove
		                (param1,*(undefined4 *)(iVar2 + param3_00 * 4 + 0x10),param3_00);
		      param3_00 = param3_00 + 1;
		    } while (param3_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x9DE4", Offset = "0x9DE4", VA = "0x9DE4")]
		private void HandleSellArtifactFromDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleSellArtifactFromDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleSellArtifactFromDropService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a589f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    DAT_ram_00a589f5 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (*(int *)(*param1_00 + 0x20) == *(int *)(Protocol_Main_DropTypes_TypeInfo + 0x20)) {
		      puVar1 = (undefined4 *)func_ii_15774(param1_00);
		      param2_00 = *puVar1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(undefined1 *)(iVar2 + 0x18) = 0;
		      Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleRun(param1,param2_00,param1);
		      return;
		    }
		    System_Activator__CreateInstance(param1_00,Protocol_Main_DropTypes_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x9DE5", Offset = "0x9DE5", VA = "0x9DE5")]
		private void HandleSellAllFromDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleSellAllFromDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleSellAllFromDropService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  uint *puVar3;
		  int *param1_00;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int param3_00;
		  int local_4;
		  
		  if (DAT_ram_00a589f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoTakeAllArtifactsFromDropAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8767);
		    DAT_ram_00a589f6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Main_ProtoTakeAllArtifactsFromDropAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Main_ProtoTakeAllArtifactsFromDropAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = param1_00[3];
		  if (local_4 < 0) {
		    uVar5 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar5 = func_ii_4419(StringLiteral_8767,uVar5,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar5,0);
		  }
		  else {
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar4 + 0x20) != *(int *)(Protocol_Main_DropTypes_TypeInfo + 0x20)) {
		      System_Activator__CreateInstance(piVar4,Protocol_Main_DropTypes_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined4 *)func_ii_15774(piVar4);
		    uVar5 = *puVar2;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		          goto code_r0x80f5c3b4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f5c3b4:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar6 + 0x14),param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    param3_00 = *param1;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(param3_00 + 0x100) * 4))
		                      (param1,*(undefined4 *)(param3_00 + 0x104));
		    *(undefined1 *)(iVar6 + 0x18) = 1;
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleRun(param1,uVar5,param3_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x9DE6", Offset = "0x9DE6", VA = "0x9DE6")]
		private void HandleTakeAllDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleTakeAllDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleTakeAllDropService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int *param1_01;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a589f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetLastDropAns_TypeInfo);
		    DAT_ram_00a589f7 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetLastDropAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetLastDropAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_01 + 0x20) == *(int *)(Protocol_Main_DropTypes_TypeInfo + 0x20)) {
		    puVar1 = (undefined4 *)func_ii_15774(param1_01);
		    uVar4 = *puVar1;
		    if (DAT_ram_00a589e4 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		      DAT_ram_00a589e4 = '\x01';
		    }
		    uVar2 = func_ii_6295(param1_00[3],Method_System_Linq_Enumerable_ToArray_ArtifactInfo___);
		    uVar4 = Gameplay_ArtifactDrop_Control_ArtifactDropController__CreateArtifactDrop
		                      (param1,uVar4,uVar2,(uint)*(byte *)(param1_00 + 4),param1);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_ArtifactDrop_Model_ArtifactDropModel__TryGetDrop(uVar2,uVar4,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar4,*(undefined4 *)(iVar3 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,Protocol_Main_DropTypes_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x9DE7", Offset = "0x9DE7", VA = "0x9DE7")]
		private void HandleGetLastDropService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetLastDropService ---
		void Gameplay_ArtifactDrop_Control_ArtifactDropController__HandleGetLastDropService
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestSellAllFromDrop(param1,param2,param2)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x1C")]
		private CraftService _craftService;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x20")]
		private DismantleMiddleware _dismantleMiddleware;
	}
}
