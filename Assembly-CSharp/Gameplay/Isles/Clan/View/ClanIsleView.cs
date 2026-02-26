using System;
using Gameplay.Isles.Axis.View;
using Gameplay.Isles.Base.View;
using Gameplay.Isles.Clan.Controller;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Clan.View
{
	// Token: 0x02000CF2 RID: 3314
	[Token(Token = "0x2000CF2")]
	public class ClanIsleView : BaseIsleView, IToolTipDataProvider
	{
		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104D")]
		public ColossusInWorldView ColossusView
		{
			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x9EB2", Offset = "0x9EB2", VA = "0x9EB2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x9EB3", Offset = "0x9EB3", VA = "0x9EB3")]
		public void Init(ClanIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_Clan_View_ClanIsleView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x3c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x9EB4", Offset = "0x9EB4", VA = "0x9EB4")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		int Gameplay_Isles_Clan_View_ClanIsleView__Deinit(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58cb0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12530);
		    DAT_ram_00a58cb0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12530,Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 0x30);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x9EB5", Offset = "0x9EB5", VA = "0x9EB5", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x9EB6", Offset = "0x9EB6", VA = "0x9EB6")]
		public ClanIsleView()
		{
		}

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ColossusInWorldView _colossusView;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x3C")]
		private ClanIsleViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ColossusView ---
		void Gameplay_Isles_Clan_View_ClanIsleView__get_ColossusView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58caf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_TypeInfo);
		    DAT_ram_00a58caf = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_TypeInfo);
		  if (DAT_ram_00a58cd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents___ctor__
		              );
		    DAT_ram_00a58cd4 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1_00,param2_00,param3_00,param4,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents___ctor__
		            );
		  *(int **)(param1 + 0x3c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
