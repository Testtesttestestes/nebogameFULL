using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public class TitledListWithCustomTitle<TTitle> : MonoBehaviour where TTitle : CustomTitle
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001BA")]
		public TTitle Title
		{
			[Token(Token = "0x6000D2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2C")]
		public void Init(TitledListWithCustomTitleArgs args)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D2D")]
		public T AddElement<T>(BaseTitledListElementArgs titledListElementArgs) where T : BaseTitledListElement
		{
			return null;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D2E")]
		public BaseTitledListElement AddElement(BaseTitledListElementArgs titledListElementArgs)
		{
			return null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2F")]
		public void Clear()
		{
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D31")]
		public TitledListWithCustomTitle()
		{
		}

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TTitle _title;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _listContainer;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _spacerPrefab;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<BaseTitledListElement> _elementsPrefabs;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Type, BaseTitledListElement> _elementsPrefabsDict;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x0")]
		private List<BaseTitledListElement> _instancedElements;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x0")]
		private List<RectTransform> _instancedSpacers;
	}
}
