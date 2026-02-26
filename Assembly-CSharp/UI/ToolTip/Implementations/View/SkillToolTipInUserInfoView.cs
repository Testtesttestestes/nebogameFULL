using System;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.VO;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public class SkillToolTipInUserInfoView : BaseToolTip<SkillToolTipInUserInfoVO>
	{
		// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x5D1A", Offset = "0x5D1A", VA = "0x5D1A", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_SkillToolTipInUserInfoView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_SkillToolTipInUserInfoVO___ctor__);
		    DAT_ram_00a5b8f0 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_SkillToolTipInUserInfoVO___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x5D1B", Offset = "0x5D1B", VA = "0x5D1B")]
		public SkillToolTipInUserInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_SkillToolTipInUserInfoView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5996c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_string__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_string__get_Data__);
		    DAT_ram_00a5996c = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(param1 + 0x14),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/SkillToolTipInUserInfoView";

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _totalSkills;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _bonusSkills;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _bonusSkillsGroup;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _totalSkillsGroup;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _itemsMedalsImagesSkillsGroup;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _rowPrefab;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _evenSprite;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Sprite _notEvenSprite;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _content;
	}
}
