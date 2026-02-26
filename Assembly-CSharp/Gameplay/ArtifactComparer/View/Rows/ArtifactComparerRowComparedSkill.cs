using System;
using Gameplay.ArtifactComparer.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CDE RID: 3294
	[Token(Token = "0x2000CDE")]
	public class ArtifactComparerRowComparedSkill : ArtifactComparerRowView
	{
		// Token: 0x0600503E RID: 20542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503E")]
		[Address(RVA = "0x9E4F", Offset = "0x9E4F", VA = "0x9E4F", Slot = "4")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowComparedSkill__HandleDataChanged
		               (int param1,int *param2,int param3,undefined4 param4)
		
		{
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (param3 == 0) {
		    func_ii_7050(param2,0,0);
		    local_8 = 0x3f800000;
		    local_10 = 0x3f8000003f800000;
		    local_48 = 0x3f800000;
		    local_50 = 0x3f8000003f800000;
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x178) * 4))
		              (param2,&local_50,*(undefined4 *)(*param2 + 0x17c));
		  }
		  else if (param3 == 1) {
		    func_ii_7050(param2,*(undefined4 *)(param1 + 0x54),0);
		    local_8 = 0x3f8000003f800000;
		    local_10 = 0x3f8000003f800000;
		    local_38 = 0x3f8000003f800000;
		    local_40 = 0x3f8000003f800000;
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x178) * 4))
		              (param2,&local_40,*(undefined4 *)(*param2 + 0x17c));
		  }
		  else if (param3 == 2) {
		    func_ii_7050(param2,*(undefined4 *)(param1 + 0x50),0);
		    local_8 = 0x3f8000003f800000;
		    local_10 = 0x3f8000003f800000;
		    local_28 = 0x3f8000003f800000;
		    local_30 = 0x3f8000003f800000;
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x178) * 4))
		              (param2,&local_30,*(undefined4 *)(*param2 + 0x17c));
		  }
		  else if (param3 == 3) {
		    func_ii_7050(param2,*(undefined4 *)(param1 + 0x4c),0);
		    local_8 = 0x3f8000003f800000;
		    local_10 = 0x3f8000003f800000;
		    local_18 = 0x3f8000003f800000;
		    local_20 = 0x3f8000003f800000;
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x178) * 4))
		              (param2,&local_20,*(undefined4 *)(*param2 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503F")]
		[Address(RVA = "0x9E50", Offset = "0x9E50", VA = "0x9E50")]
		private void SetComparisonResult(Image image, ComparedSkillData.ComparisonResult result)
		{
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005040")]
		[Address(RVA = "0x9E51", Offset = "0x9E51", VA = "0x9E51")]
		public ArtifactComparerRowComparedSkill()
		{
		}

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _compareResultImage1;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleIconValue _iconValue1;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _compareResultImage2;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleIconValue _iconValue2;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CanvasGroup _canvasGroup1;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup2;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Sprite _greaterIcon;

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _lessIcon;

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Sprite _equalsIcon;
	}
}
