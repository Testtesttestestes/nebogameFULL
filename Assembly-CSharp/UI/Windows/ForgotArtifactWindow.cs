using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Main;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	public class ForgotArtifactWindow : BaseDialogWindow<ForgotArtifactWindow.ForgotItemsWindowArgs>
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022D")]
		public override string WindowId
		{
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x61B2", Offset = "0x61B2", VA = "0x61B2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x61B3", Offset = "0x61B3", VA = "0x61B3")]
		public static ForgotArtifactWindow Show(DropTypes dropType, ArtifactData[] artifacts)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_ForgotArtifactWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58a5e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58a5e = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		                      );
		  iVar2 = *(int *)(iVar2 + 0x2c);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  iVar2 = UnityEngine_Mathf__Min(*(undefined4 *)(iVar2 + 0xc),4,0);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      param2_00 = *(undefined4 *)(param1 + 0x40);
		      param1_01 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = (int *)func_ii_6805(param1_01,param2_00,
		                                      Method_UnityEngine_Object_Instantiate_ArtifactView___);
		      iVar3 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		                          );
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                (param1_00,*(undefined4 *)(*(int *)(iVar3 + 0x2c) + iVar1 * 4 + 0x10),
		                 *(undefined4 *)(*param1_00 + 0x13c));
		      iVar3 = param1_00[0x14];
		      local_8 = Mono_Security_ASN1Convert__ToOid
		                          (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		      *(undefined4 *)(local_8 + 0x10) = 5;
		      local_4 = 0;
		      local_10 = 0;
		      local_18 = CONCAT44(local_8,iVar3);
		      local_c = iVar3;
		      func_ii_7564(param1_00,&local_18,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_Windows_ForgotArtifactWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58a5e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58a5e = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		                      );
		  iVar2 = *(int *)(iVar2 + 0x2c);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  iVar2 = UnityEngine_Mathf__Min(*(undefined4 *)(iVar2 + 0xc),4,0);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      param2_00 = *(undefined4 *)(param1 + 0x40);
		      param1_01 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = (int *)func_ii_6805(param1_01,param2_00,
		                                      Method_UnityEngine_Object_Instantiate_ArtifactView___);
		      iVar3 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_ForgotArtifactWindow_ForgotItemsWindowArgs__get_WindowArgs__
		                          );
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                (param1_00,*(undefined4 *)(*(int *)(iVar3 + 0x2c) + iVar1 * 4 + 0x10),
		                 *(undefined4 *)(*param1_00 + 0x13c));
		      iVar3 = param1_00[0x14];
		      local_8 = Mono_Security_ASN1Convert__ToOid
		                          (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		      *(undefined4 *)(local_8 + 0x10) = 5;
		      local_4 = 0;
		      local_10 = 0;
		      local_18 = CONCAT44(local_8,iVar3);
		      local_c = iVar3;
		      func_ii_7564(param1_00,&local_18,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x61B4", Offset = "0x61B4", VA = "0x61B4")]
		public static ForgotArtifactWindow Show(ArtifactData[] artifacts, Action targetCallback)
		{
			return null;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x61B5", Offset = "0x61B5", VA = "0x61B5", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void UI_Windows_ForgotArtifactWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs___ctor__
		              );
		    DAT_ram_00a58a5f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ForgotArtifactWindow_ForgotItemsWindowArgs___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x61B6", Offset = "0x61B6", VA = "0x61B6")]
		public ForgotArtifactWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_ForgotArtifactWindow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ForgotArtifactWindow_ForgotItemsWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7836);
		    DAT_ram_00a58a60 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ForgotArtifactWindow_ForgotItemsWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_7836,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ForgotArtifactWindow";

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		public const int MAX_DISPLAYED_IN_DIALOG_ARTIFACTS_COUNT = 4;

		// Token: 0x02000295 RID: 661
		[Token(Token = "0x2000295")]
		public class ForgotItemsWindowArgs : BaseDialogWindow<ForgotArtifactWindow.ForgotItemsWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x61B7", Offset = "0x61B7", VA = "0x61B7")]
			public ForgotItemsWindowArgs(ArtifactData[] artifacts)
			{
			}

			// Token: 0x040007E6 RID: 2022
			[Token(Token = "0x40007E6")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		UI_Windows_ForgotArtifactWindow__get_WindowId(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a5c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ForgotArtifactWindow___c__DisplayClass6_0__Show_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_ForgotArtifactWindow___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a58a5c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(UI_Windows_ForgotArtifactWindow___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param2_00,
		             Method_UI_Windows_ForgotArtifactWindow___c__DisplayClass6_0__Show_b__0__,0);
		  uVar1 = UI_Windows_ForgotArtifactWindow__Show(param2,uVar1,param2_00);
		  return uVar1;
		}
		*/

}
