using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public class ImageAnimation : MonoBehaviour
	{
		// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x5C08", Offset = "0x5C08", VA = "0x5C08")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		int UI_ImageAnimation__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b87c == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ImageAnimation__ShowAnimation_d__9_TypeInfo);
		    DAT_ram_00a5b87c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_ImageAnimation__ShowAnimation_d__9_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x5C09", Offset = "0x5C09", VA = "0x5C09")]
		private IEnumerator ShowAnimation()
		{
		/* --- GHIDRA: ShowAnimation ---
		void UI_ImageAnimation__ShowAnimation(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x28) = 0x3f80000000000001;
		  *(undefined8 *)(param1 + 0x20) = 0x3f99999a3f800000;
		  *(undefined8 *)(param1 + 0x18) = 0x4000000040000000;
		  *(undefined8 *)(param1 + 0x30) = 0x100000000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x5C0A", Offset = "0x5C0A", VA = "0x5C0A")]
		public ImageAnimation()
		{
		}

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _image;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _startDelay;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _duration;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _repeatDelay;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _scale;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Ease _scaleEase;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _alpha;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Ease _alphaEase;
	}
}
