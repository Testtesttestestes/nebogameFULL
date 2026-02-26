using System;
using Gameplay.Isles.Axis.View;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D10 RID: 3344
	[Token(Token = "0x2000D10")]
	public class ColossusOnUserIsleView : MonoBehaviour
	{
		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001085")]
		public ColossusInWorldView ColossusView
		{
			[Token(Token = "0x600519A")]
			[Address(RVA = "0x9F76", Offset = "0x9F76", VA = "0x9F76")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519B")]
		[Address(RVA = "0x9F77", Offset = "0x9F77", VA = "0x9F77")]
		public void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_User_View_ColossusOnUserIsleView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x14);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519C")]
		[Address(RVA = "0x9F78", Offset = "0x9F78", VA = "0x9F78")]
		public void Deinit()
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x9F79", Offset = "0x9F79", VA = "0x9F79")]
		public ColossusOnUserIsleView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_View_ColossusOnUserIsleView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x04002C5D RID: 11357
		[Token(Token = "0x4002C5D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ColossusInWorldView _colossusView;

		// Token: 0x04002C5E RID: 11358
		[Token(Token = "0x4002C5E")]
		[FieldOffset(Offset = "0x14")]
		private ColossusOnUserIsleViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ColossusView ---
		void Gameplay_Isles_User_View_ColossusOnUserIsleView__get_ColossusView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d21 == '\0') {
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
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_TypeInfo);
		    DAT_ram_00a58d21 = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a58d8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView___ctor__
		              );
		    DAT_ram_00a58d8d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x14) = param1_00;
		  return;
		}
		*/

}
