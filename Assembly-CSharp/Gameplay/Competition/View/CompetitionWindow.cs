using System;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Competition.View
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[AddComponentMenu("Competition/View/CompetitionWindow")]
	public class CompetitionWindow : ClosableBaseWindow<CompetitionWindow.CompetitionWindowArgs>
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A8B")]
		public override string WindowId
		{
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x857E", Offset = "0x857E", VA = "0x857E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x857F", Offset = "0x857F", VA = "0x857F", Slot = "22")]
		protected override void OnShow(CompetitionWindow.CompetitionWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Competition_View_CompetitionWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63a83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a63a83 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs__OnClose__
		            );
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8233593a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x8233593a:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x8580", Offset = "0x8580", VA = "0x8580", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Competition_View_CompetitionWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a84 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs___ctor__
		              );
		    DAT_ram_00a63a84 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x8581", Offset = "0x8581", VA = "0x8581")]
		public CompetitionWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_View_CompetitionWindow___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a85 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23035);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    DAT_ram_00a63a85 = '\x01';
		  }
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(int **)(param1 + 0x18) = param2;
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x104));
		  uVar1 = StringLiteral_23035;
		  if (*(int *)(iVar2 + 0x2c) == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = Core_Extensions_Dict_CombatEventDicExt__GetSoundAssetId
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x2c) + 8),0);
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,uVar1,uVar3,Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  iVar2 = **(int **)(param1 + 0x18);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		  uVar1 = StringLiteral_23033;
		  if (*(int *)(iVar2 + 0x2c) == 0) {
		    local_8 = 0;
		  }
		  else {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x2c) + 0xc) + 0x10),
		               Method_System_Nullable_uint___ctor__);
		  }
		  uVar3 = func_ii_1081(System_Nullable_uint__TypeInfo,&local_8);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,uVar1,uVar3,Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  return;
		}
		*/

		}

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Competition/CompetitionWindow";

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CompetitionView _view;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020008DB RID: 2267
		[Token(Token = "0x20008DB")]
		public class CompetitionWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355F")]
			[Address(RVA = "0x8582", Offset = "0x8582", VA = "0x8582")]
			public CompetitionWindowArgs(CompetitionController controller)
			{
			}

			// Token: 0x04001D32 RID: 7474
			[Token(Token = "0x4001D32")]
			[FieldOffset(Offset = "0x18")]
			public readonly CompetitionController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Competition_View_CompetitionWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a63a82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_CompetitionViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a63a82 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CompetitionWindow_CompetitionWindowArgs__OnShow__
		              );
		  iVar4 = **(int **)(param2 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (*(int **)(param2 + 0x18),*(undefined4 *)(iVar4 + 0x104));
		  iVar4 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar4 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Competition_Control_CompetitionViewMediator_TypeInfo);
		  if (DAT_ram_00a63ae2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView___ctor__
		              );
		    DAT_ram_00a63ae2 = '\x01';
		  }
		  uVar1 = 0;
		  MVC_AbstractController_object__object___set_Model
		            (param1_00,uVar2,param3_00,param4,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView___ctor__
		            );
		  *(int **)(param1 + 0x40) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x8233584c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x8233584c:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  return;
		}
		*/

}
