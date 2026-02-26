using System;
using Gameplay.Isles.Base.View;
using Gameplay.Isles.User.Controller;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D21 RID: 3361
	[Token(Token = "0x2000D21")]
	public class UserIsleView : BaseIsleView, IToolTipDataProvider
	{
		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B1")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x600521F")]
			[Address(RVA = "0x9FF6", Offset = "0x9FF6", VA = "0x9FF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B2")]
		public IsleAccountMarkersLayerView IsleAccountMarkersLayer
		{
			[Token(Token = "0x6005220")]
			[Address(RVA = "0x9FF7", Offset = "0x9FF7", VA = "0x9FF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B3")]
		public IsleAnimationsView IsleAnimationsView
		{
			[Token(Token = "0x6005221")]
			[Address(RVA = "0x9FF8", Offset = "0x9FF8", VA = "0x9FF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B4")]
		public IsleBonusesView IsleBonusesView
		{
			[Token(Token = "0x6005222")]
			[Address(RVA = "0x9FF9", Offset = "0x9FF9", VA = "0x9FF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B5")]
		public IsleDecorationsView IsleDecorationsView
		{
			[Token(Token = "0x6005223")]
			[Address(RVA = "0x9FFA", Offset = "0x9FFA", VA = "0x9FFA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005224")]
		[Address(RVA = "0x9FFB", Offset = "0x9FFB", VA = "0x9FFB")]
		public void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_User_View_UserIsleView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x4c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005225")]
		[Address(RVA = "0x9FFC", Offset = "0x9FFC", VA = "0x9FFC")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		int Gameplay_Isles_User_View_UserIsleView__Deinit(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58d6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12544);
		    DAT_ram_00a58d6e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_UserData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12544,Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x4c) + 8) + 8);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005226")]
		[Address(RVA = "0x9FFD", Offset = "0x9FFD", VA = "0x9FFD", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005227")]
		[Address(RVA = "0x9FFE", Offset = "0x9FFE", VA = "0x9FFE")]
		public UserIsleView()
		{
		}

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IsleBonusesView _isleBonusesView;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private IsleDecorationsView _isleDecorationsView;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IsleAnimationsView _isleAnimationsView;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private IsleAccountMarkersLayerView _isleAccountMarkersLayer;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x4C")]
		private UserIsleViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsleDecorationsView ---
		void Gameplay_Isles_User_View_UserIsleView__get_IsleDecorationsView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_Controller_UserIsleViewMediator_TypeInfo);
		    DAT_ram_00a58d6d = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_User_Controller_UserIsleViewMediator_TypeInfo);
		  Gameplay_Isles_User_Controller_UserIsleController__SetupMonsterTimerRoutine_d__35__System_Collections_IEnumerator_get_Current
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x4c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
