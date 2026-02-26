using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.StoneValuesWidget
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	public class StoneValuesWidgetRowView : MonoBehaviour
	{
		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B02")]
		public Image StoneImg
		{
			[Token(Token = "0x60037CF")]
			[Address(RVA = "0x87B1", Offset = "0x87B1", VA = "0x87B1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B03")]
		public Image SkillImg
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x87B2", Offset = "0x87B2", VA = "0x87B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B04")]
		public TextMeshProUGUI ValueField
		{
			[Token(Token = "0x60037D1")]
			[Address(RVA = "0x87B3", Offset = "0x87B3", VA = "0x87B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x87B4", Offset = "0x87B4", VA = "0x87B4")]
		public StoneValuesWidgetRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetRowView___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a566d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetView__Draw_d__6_TypeInfo);
		    DAT_ram_00a566d9 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Combat_View_StoneValuesWidget_StoneValuesWidgetView__Draw_d__6_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04001ED9 RID: 7897
		[Token(Token = "0x4001ED9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _stoneImg;

		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _skillImg;

		// Token: 0x04001EDB RID: 7899
		[Token(Token = "0x4001EDB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueField;
	}
}
