using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC1 RID: 3009
	[Token(Token = "0x2000BC1")]
	public class BlitzTournamentBracketInfoBox : MonoBehaviourWithStates<BlitzTournamentBracketInfoBox.State>
	{
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EE7")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x60049D2")]
			[Address(RVA = "0x983C", Offset = "0x983C", VA = "0x983C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EE8")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x60049D3")]
			[Address(RVA = "0x983D", Offset = "0x983D", VA = "0x983D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EE9")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x60049D4")]
			[Address(RVA = "0x983E", Offset = "0x983E", VA = "0x983E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x060049D5 RID: 18901 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEA")]
		public GameObject Banner
		{
			[Token(Token = "0x60049D5")]
			[Address(RVA = "0x983F", Offset = "0x983F", VA = "0x983F")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x9840", Offset = "0x9840", VA = "0x9840")]
		public BlitzTournamentBracketInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_View_BlitzTournamentBracketInfoBox___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  int local_4;
		  
		  param1_01 = (int *)0x0;
		  if (DAT_ram_00a60895 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a60895 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,5,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  param2_00 = Gameplay_Combat_IManageCombat_TypeInfo;
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(local_4 + 0xc);
		    if ((iVar2 != 0) &&
		       (param1_01 = (int *)func_ii_1082(iVar2,Gameplay_Combat_IManageCombat_TypeInfo),
		       param1_01 == (int *)0x0)) {
		      System_Activator__CreateInstance(iVar2,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (param2_00 == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cf2731;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,param2_00,0);
		code_r0x81cf2731:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _banner;

		// Token: 0x02000BC2 RID: 3010
		[Token(Token = "0x2000BC2")]
		public enum State
		{
			// Token: 0x04002821 RID: 10273
			[Token(Token = "0x4002821")]
			UNKNOWN,
			// Token: 0x04002822 RID: 10274
			[Token(Token = "0x4002822")]
			LOSE_PAGE,
			// Token: 0x04002823 RID: 10275
			[Token(Token = "0x4002823")]
			WIN_PAGE,
			// Token: 0x04002824 RID: 10276
			[Token(Token = "0x4002824")]
			BRACKET
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Banner ---
		void Gameplay_BlitzTournament_View_BlitzTournamentBracketInfoBox__get_Banner
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60894 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State___ctor__);
		    DAT_ram_00a60894 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_BlitzTournamentBracketInfoBox_State___ctor__);
		  return;
		}
		*/

}
