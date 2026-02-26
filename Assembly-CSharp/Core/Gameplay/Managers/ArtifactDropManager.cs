using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Gameplay.ArtifactDrop;
using Gameplay.ArtifactDrop.Control;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using UI.Rewards.Renderers;
using UnityEngine;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001140 RID: 4416
	[Token(Token = "0x2001140")]
	public class ArtifactDropManager : IGameManager, IBaseManager, IAnimationProvider
	{
		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001537")]
		public string Name
		{
			[Token(Token = "0x600679A")]
			[Address(RVA = "0xB2C6", Offset = "0xB2C6", VA = "0xB2C6", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400025C RID: 604
		// (add) Token: 0x0600679B RID: 26523 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679C RID: 26524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600679B")]
			[Address(RVA = "0xB2C7", Offset = "0xB2C7", VA = "0xB2C7", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600679C")]
			[Address(RVA = "0xB2C8", Offset = "0xB2C8", VA = "0xB2C8", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025D RID: 605
		// (add) Token: 0x0600679D RID: 26525 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679E RID: 26526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600679D")]
			[Address(RVA = "0xB2C9", Offset = "0xB2C9", VA = "0xB2C9", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600679E")]
			[Address(RVA = "0xB2CA", Offset = "0xB2CA", VA = "0xB2CA", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001538")]
		public ArtifactDropController Controller
		{
			[Token(Token = "0x600679F")]
			[Address(RVA = "0xB2CB", Offset = "0xB2CB", VA = "0xB2CB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A0")]
		[Address(RVA = "0xB2CC", Offset = "0xB2CC", VA = "0xB2CC")]
		public void AddView(ArtifactRewardRender view)
		{
		/* --- GHIDRA: AddView ---
		void Core_Gameplay_Managers_ArtifactDropManager__AddView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *local_4;
		  
		  if (DAT_ram_00a5a987 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TryGetValue__
		              );
		    DAT_ram_00a5a987 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x1c),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(param1 + 0x1c),param2,
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Remove__
		              );
		    (**(code **)((ulonglong)*(uint *)(*local_4 + 0x130) * 4))
		              (local_4,*(undefined4 *)(*local_4 + 0x134));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A1")]
		[Address(RVA = "0xB2CD", Offset = "0xB2CD", VA = "0xB2CD")]
		public void RemoveView(ArtifactRewardRender view)
		{
		/* --- GHIDRA: RemoveView ---
		void Core_Gameplay_Managers_ArtifactDropManager__RemoveView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a988 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAnimationTarget__Add__);
		    DAT_ram_00a5a988 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_IAnimationTarget__Add__;
		  param1_00 = *(int *)(param1 + 0x20);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A2")]
		[Address(RVA = "0xB2CE", Offset = "0xB2CE", VA = "0xB2CE")]
		public void AddAnimationTarget(IAnimationTarget target)
		{
		/* --- GHIDRA: AddAnimationTarget ---
		void Core_Gameplay_Managers_ArtifactDropManager__AddAnimationTarget
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a989 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAnimationTarget__Remove__)
		    ;
		    DAT_ram_00a5a989 = '\x01';
		  }
		  func_ii_4876(*(undefined4 *)(param1 + 0x20),param2,
		               Method_System_Collections_Generic_List_IAnimationTarget__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A3")]
		[Address(RVA = "0xB2CF", Offset = "0xB2CF", VA = "0xB2CF")]
		public void RemoveAnimationTarget(IAnimationTarget target)
		{
		/* --- GHIDRA: RemoveAnimationTarget ---
		void Core_Gameplay_Managers_ArtifactDropManager__RemoveAnimationTarget(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *piVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5a98a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactDrop_Control_ArtifactDropController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactDrop_ArtifactDropEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactDrop_Model_ArtifactDropModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a98a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x8129f3ca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129f3ca:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x8129f47c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129f47c:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar5 = unnamed_function_1417(Gameplay_ArtifactDrop_Model_ArtifactDropModel_TypeInfo);
		  Gameplay_ArtifactDrop_Model_ArtifactDropModel__Dispose(uVar5,uVar3,uVar4,param1,0);
		  *(undefined4 *)(param1 + 0x14) = uVar5;
		  uVar3 = unnamed_function_1417(Gameplay_ArtifactDrop_ArtifactDropEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x8129f58b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129f58b:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x1b0);
		        goto code_r0x8129f637;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x8129f637:
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		        goto code_r0x8129f6e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8129f6e3:
		  piVar8 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar1 = 0;
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xf8);
		        goto code_r0x8129f765;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,7);
		code_r0x8129f765:
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		        goto code_r0x8129f80d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8129f80d:
		  piVar8 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  uVar1 = 0;
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xf0);
		        goto code_r0x8129f88f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,6);
		code_r0x8129f88f:
		  param5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware_TypeInfo);
		  Pathfinding_Ionic_Zlib_InternalConstants___cctor(param1_00,uVar5,uVar6,uVar7,param5,0,0);
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  uVar7 = *(undefined4 *)(param1 + 0x14);
		  uVar5 = unnamed_function_1417(Gameplay_ArtifactDrop_Control_ArtifactDropController_TypeInfo);
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__Dispose
		            (uVar5,uVar3,uVar4,param1_00,uVar7,uVar6,0);
		  *(undefined4 *)(param1 + 0x10) = uVar5;
		  MVC_AbstractController__Dispose(uVar5,0);
		  iVar9 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		            (*(undefined4 *)(iVar9 + 0x20),param1,*(undefined4 *)(iVar9 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A4")]
		[Address(RVA = "0xB2D0", Offset = "0xB2D0", VA = "0xB2D0", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ArtifactDropManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a98b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ArtifactRewardRender__ArtifactDropViewMediator__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ArtifactRewardRender__ArtifactDropViewMediator__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ArtifactRewardRender__ArtifactDropViewMediator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ArtifactRewardRender__ArtifactDropViewMediator__GetEnumerator__
		              );
		    DAT_ram_00a5a98b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ArtifactRewardRender__ArtifactDropViewMediator__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ArtifactRewardRender__ArtifactDropViewMediator__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8129fa5a;
		    }
		    if (iVar2 == 0) goto code_r0x8129fab0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*local_8._4_4_ + 0x130),local_8._4_4_,
		               *(undefined4 *)(*local_8._4_4_ + 0x134));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8129fa5a:
		  iVar4 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8129fab0:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x1c),
		                 Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Clear__
		                );
		      iVar4 = **(int **)(param1 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                (*(int **)(param1 + 0x14),*(undefined4 *)(iVar4 + 0xec));
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		      iVar4 = **(int **)(param1 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xec));
		      *(undefined8 *)(param1 + 0x10) = 0;
		      iVar4 = *(int *)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		      return;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x4e,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A5")]
		[Address(RVA = "0xB2D1", Offset = "0xB2D1", VA = "0xB2D1", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		uint Core_Gameplay_Managers_ArtifactDropManager__Deinit
		               (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a98c == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_IAnimationTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAnimationTarget__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAnimationTarget__get_Item__);
		    DAT_ram_00a5a98c = '\x01';
		  }
		  *param3 = 0;
		  iVar4 = *(int *)(*(int *)(param1 + 0x20) + 0xc);
		  if (iVar4 != 0) {
		    uVar1 = 0;
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (*(int *)(param1 + 0x20),0,
		                                  Method_System_Collections_Generic_List_IAnimationTarget__get_Item__
		                                 );
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Animations_IAnimationTarget_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8129fc69;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Animations_IAnimationTarget_TypeInfo,0);
		code_r0x8129fc69:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		    *param3 = uVar3;
		  }
		  return (uint)(iVar4 != 0);
		}
		*/

		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x60067A6")]
		[Address(RVA = "0xB2D2", Offset = "0xB2D2", VA = "0xB2D2", Slot = "11")]
		private bool TryStartAnimation(Transform target, out float duration)
		{
			return default(bool);
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A7")]
		[Address(RVA = "0xB2D3", Offset = "0xB2D3", VA = "0xB2D3")]
		public ArtifactDropManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ArtifactDropManager___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a98e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a98e = '\x01';
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

		}

		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		[FieldOffset(Offset = "0x10")]
		private ArtifactDropController _controller;

		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		[FieldOffset(Offset = "0x14")]
		private ArtifactDropModel _model;

		// Token: 0x0400374B RID: 14155
		[Token(Token = "0x400374B")]
		[FieldOffset(Offset = "0x18")]
		private ArtifactDropEvents _events;

		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<ArtifactRewardRender, ArtifactDropViewMediator> _mediators;

		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<IAnimationTarget> _animationTargets;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ArtifactDropManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a982 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a982 = '\x01';
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
		void Core_Gameplay_Managers_ArtifactDropManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a983 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a983 = '\x01';
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
		void Core_Gameplay_Managers_ArtifactDropManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a984 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a984 = '\x01';
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
		void Core_Gameplay_Managers_ArtifactDropManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a985 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a985 = '\x01';
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


		/* --- GHIDRA: get_Controller ---
		void Core_Gameplay_Managers_ArtifactDropManager__get_Controller
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *local_4;
		  
		  if (DAT_ram_00a5a986 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TryGetValue__
		              );
		    DAT_ram_00a5a986 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x1c),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    param4 = *(undefined4 *)(param1 + 0x10);
		    param3_00 = *(undefined4 *)(param1 + 0x18);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    param1_00 = (int *)unnamed_function_1417
		                                 (Gameplay_ArtifactDrop_Control_ArtifactDropViewMediator_TypeInfo);
		    Gameplay_ArtifactDrop_Control_ArtifactDropController___c__DisplayClass29_0___HandleDismantleArtifactFromDropService_b__0
		              (param1_00,param2_00,param3_00,param4,0);
		    local_4 = param1_00;
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0x1c),param2,param1_00,
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__Add__
		              );
		  }
		  (**(code **)((ulonglong)*(uint *)(*local_4 + 0x160) * 4))
		            (local_4,param2,*(undefined4 *)(*local_4 + 0x164));
		  return;
		}
		*/


		/* --- GHIDRA: Animations.IAnimationProvider.TryStartAnimation ---
		void Core_Gameplay_Managers_ArtifactDropManager__Animations_IAnimationProvider_TryStartAnimation
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a98d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAnimationTarget___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IAnimationTarget__TypeInfo);
		    DAT_ram_00a5a98d = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_ArtifactRewardRender__ArtifactDropViewMediator___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IAnimationTarget__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IAnimationTarget___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

}
