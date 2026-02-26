using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using Utils;

namespace Gameplay.UserInterface.View.Update
{
	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	public class RecommendedAppUpdateView : MonoPointerClickHandler, IProgress
	{
		// Token: 0x060016E6 RID: 5862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x68A5", Offset = "0x68A5", VA = "0x68A5")]
		private void DisplayProgress()
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E4")]
		public float Value
		{
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x68A6", Offset = "0x68A6", VA = "0x68A6", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60016E8")]
			[Address(RVA = "0x68A7", Offset = "0x68A7", VA = "0x68A7", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x68A8", Offset = "0x68A8", VA = "0x68A8", Slot = "10")]
		public void SetProgress(float current, float total)
		{
		/* --- GHIDRA: SetProgress ---
		void Gameplay_UserInterface_View_Update_RecommendedAppUpdateView__SetProgress
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59877 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__)
		    ;
		    DAT_ram_00a59877 = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		                          );
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,1,
		             Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x68A9", Offset = "0x68A9", VA = "0x68A9")]
		public void ShowReadyToInstall()
		{
		/* --- GHIDRA: ShowReadyToInstall ---
		void Gameplay_UserInterface_View_Update_RecommendedAppUpdateView__ShowReadyToInstall
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59878 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__)
		    ;
		    DAT_ram_00a59878 = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		                          );
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,0,
		             Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x68AA", Offset = "0x68AA", VA = "0x68AA")]
		public void ShowIdle()
		{
		/* --- GHIDRA: ShowIdle ---
		void Gameplay_UserInterface_View_Update_RecommendedAppUpdateView__ShowIdle
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59879 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__)
		    ;
		    DAT_ram_00a59879 = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponent_MonoBehaviourWithStates_RecommendedAppUpdateViewState____
		                          );
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,2,
		             Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x68AB", Offset = "0x68AB", VA = "0x68AB")]
		public void ShowInProgress()
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x68AC", Offset = "0x68AC", VA = "0x68AC")]
		public RecommendedAppUpdateView()
		{
		}

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _progressTextFiled;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _marker;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x28")]
		private float _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		void Gameplay_UserInterface_View_Update_RecommendedAppUpdateView__get_Value
		               (int param1,float param2,undefined4 param3)
		
		{
		  *(float *)(param1 + 0x28) = param2;
		  Gameplay_UserInterface_View_Update_MarkerView___ctor(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void Gameplay_UserInterface_View_Update_RecommendedAppUpdateView__set_Value
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  *(float *)(param1 + 0x28) = param2 / param3;
		  Gameplay_UserInterface_View_Update_MarkerView___ctor(param1,param1);
		  return;
		}
		*/

}
