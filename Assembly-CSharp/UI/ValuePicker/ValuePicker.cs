using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ValuePicker
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	public class ValuePicker<T> : MonoBehaviour
	{
		// Token: 0x140000CE RID: 206
		// (add) Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CE")]
		public event Action<T> SelectionChangedEvent
		{
			[Token(Token = "0x60008D3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D5")]
		private void Awake()
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D7")]
		public void Init(IList<T> data, Func<T, string> getLabelMethod)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008D8")]
		private IList<T> Loop(IList<T> finalData)
		{
			return null;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D9")]
		public void ScrollTo(T item)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DA")]
		private void ScrollToIndex(int index)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DB")]
		private void MinButtonClickHandler()
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DC")]
		private void MaxButtonClickHandler()
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DD")]
		private void SpinnerOnCurrentSelectedIndexChangedEvent(int index)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DE")]
		public ValuePicker()
		{
		}

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ValuePickerOsaSpinner _spinner;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Button _minButton;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Button _maxButton;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x0")]
		private Func<T, string> _getLabelLambda;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x0")]
		private IList<T> _rawData;
	}
}
