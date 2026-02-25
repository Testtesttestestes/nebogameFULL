using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	public class TitledList : MonoBehaviour
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public bool IsInit
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x600C", Offset = "0x600C", VA = "0x600C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x600D", Offset = "0x600D", VA = "0x600D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		public string Title
		{
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x600E", Offset = "0x600E", VA = "0x600E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x600F", Offset = "0x600F", VA = "0x600F")]
			set
			{
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x6010", Offset = "0x6010", VA = "0x6010")]
		public void Init(TitledListArgs args)
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x6011", Offset = "0x6011", VA = "0x6011")]
		public BaseTitledListElement AddElement(BaseTitledListElementArgs titledListElementArgs)
		{
			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x6012", Offset = "0x6012", VA = "0x6012")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x6013", Offset = "0x6013", VA = "0x6013")]
		public TitledList()
		{
		}

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _listContainer;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _spacerPrefab;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private List<BaseTitledListElement> _elementsPrefabs;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, BaseTitledListElement> _elementsPrefabsDict;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x24")]
		private List<BaseTitledListElement> _instancedElements;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x28")]
		private List<RectTransform> _instancedSpacers;
	}
}
