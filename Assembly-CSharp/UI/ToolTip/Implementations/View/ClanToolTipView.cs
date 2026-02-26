using System;
using Gameplay.UserInfo.View;
using Gameplay.UserInterface.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public class ClanToolTipView : BaseToolTip<ClanData>
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x5D0D", Offset = "0x5D0D", VA = "0x5D0D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_ClanToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanData___ctor__);
		    DAT_ram_00a5b8e3 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_ClanData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x5D0E", Offset = "0x5D0E", VA = "0x5D0E")]
		public ClanToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_ClanToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5b8e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_CollectionToolTipVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_CollectionToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5b8e4 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(iVar2 + 8),
		               *(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(iVar2 + 0x10),0);
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    iVar2 = Gameplay_Collections_Model_CollectionDicGroup___ctor
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x18),
		                       *(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		    uVar3 = *(undefined4 *)(iVar2 + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		    piVar1 = (int *)func_ii_7307(param1_00,uVar3,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanToolTipView";

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanLeagueBannerView _clanLeagueBannerView;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CultView _cult;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsTableTitle;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TitlePlaceIconValueBackground _ratingPontRowPrefab;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _ratingPointsContainer;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TitleIconValueBackground _totalMembersNum;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TitleIconValueBackground _generalMembersNum;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TitleIconValueBackground _legendMembersNum;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _restrictionsCount;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _restrictionsObjects;
	}
}
