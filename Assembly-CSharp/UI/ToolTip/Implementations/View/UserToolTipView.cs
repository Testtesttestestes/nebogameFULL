using System;
using Core.Data;
using Gameplay.Aprs.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.View.Parts;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class UserToolTipView : BaseToolTip<UserData>
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x5D21", Offset = "0x5D21", VA = "0x5D21", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_UserToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59972 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_UserData___ctor__);
		    DAT_ram_00a59972 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_UserData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x5D22", Offset = "0x5D22", VA = "0x5D22")]
		public UserToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_UserToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59973 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9084);
		    DAT_ram_00a59973 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9084,1,0,1,0,0,0,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/UserToolTipView";

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _userNick;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatPlayerLevelView _level;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AprViewSmall _aprViewSmall;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CultView _cult;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RatingBackground _headerBackground;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsTableTitle;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TitleIconValueBackground _ratingPontRowPrefab;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform _ratingPointsContainer;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TitleIconValueBackground _clanRow;
	}
}
