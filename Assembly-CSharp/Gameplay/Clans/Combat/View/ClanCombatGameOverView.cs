using System;
using Animations;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A91 RID: 2705
	[Token(Token = "0x2000A91")]
	public class ClanCombatGameOverView : CombatGameOverView
	{
		// Token: 0x060040D4 RID: 16596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x8F8B", Offset = "0x8F8B", VA = "0x8F8B", Slot = "5")]
		public override CombatGameOverView Show(CombatGameOverView.CombatGameOverViewArgs args)
		{
		/* --- GHIDRA: Show ---
		int Gameplay_Clans_Combat_View_ClanCombatGameOverView__Show
		              (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a57765 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17762);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15056);
		    DAT_ram_00a57765 = '\x01';
		  }
		  if (((uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8) <=
		       (uint)*(byte *)(*param2 + 0xb8)) &&
		     (piVar1 = param2,
		     *(int *)(*(int *)(*param2 + 100) +
		              (uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8) * 4 + -4) !=
		     Gameplay_Clans_Combat_Model_GameOverData_TypeInfo)) {
		    piVar1 = (int *)0x0;
		  }
		  puVar3 = &StringLiteral_17762;
		  if ((char)param2[2] == '\0') {
		    puVar3 = &StringLiteral_10333;
		  }
		  uVar4 = *puVar3;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar4,1,0,1,0,0,0,0);
		  if (piVar1[9] == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15056,1,0,1,0,0,0,0);
		    puVar3 = (undefined4 *)(param1 + 0x4c);
		  }
		  else {
		    iVar2 = 0x2c;
		    if ((char)param2[2] == '\0') {
		      iVar2 = 0x30;
		    }
		    puVar3 = (undefined4 *)(param1 + iVar2);
		  }
		  param1_00 = *puVar3;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_6805(param1_00,param3,
		                       Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___);
		  iVar5 = **(int **)(iVar2 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (*(int **)(iVar2 + 0x1c),uVar4,*(undefined4 *)(iVar5 + 0x2d4));
		  Animations_InIdleOutSpineAnimation__get_Particles(iVar2,0);
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x8F8C", Offset = "0x8F8C", VA = "0x8F8C", Slot = "6")]
		protected override InIdleOutSpineAnimation CreateResultAnimation(GameOverData gameOverData, Transform parent)
		{
		/* --- GHIDRA: CreateResultAnimation ---
		void Gameplay_Clans_Combat_View_ClanCombatGameOverView__CreateResultAnimation
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_CombatGameOverView__HandleCloseButtonClickEvent(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x8F8D", Offset = "0x8F8D", VA = "0x8F8D")]
		public ClanCombatGameOverView()
		{
		}

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private InIdleOutSpineAnimation _tieAnimation;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameAssetViewRawImage _myAvatar;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameAssetViewRawImage _enemyAvatar;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClanCombatGameOverView.TopBar _leftTopBars;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ClanCombatGameOverView.TopBar _rightTopBars;

		// Token: 0x02000A92 RID: 2706
		[Token(Token = "0x2000A92")]
		[Serializable]
		public class TopBar
		{
			// Token: 0x060040D7 RID: 16599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D7")]
			[Address(RVA = "0x8F8E", Offset = "0x8F8E", VA = "0x8F8E")]
			public TopBar()
			{
			}

			// Token: 0x040023FB RID: 9211
			[Token(Token = "0x40023FB")]
			[FieldOffset(Offset = "0x8")]
			public TextMeshProUGUI NickField;

			// Token: 0x040023FC RID: 9212
			[Token(Token = "0x40023FC")]
			[FieldOffset(Offset = "0xC")]
			public CombatPlayerLevelView Level;

			// Token: 0x040023FD RID: 9213
			[Token(Token = "0x40023FD")]
			[FieldOffset(Offset = "0x10")]
			public CultWhitBackground СultOnNickView;
		}
	}
}
