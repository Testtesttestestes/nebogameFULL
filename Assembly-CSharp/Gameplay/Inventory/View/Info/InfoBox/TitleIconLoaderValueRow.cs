using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class TitleIconLoaderValueRow : TitleRowView
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079B")]
		public string Value
		{
			[Token(Token = "0x600282D")]
			[Address(RVA = "0x7952", Offset = "0x7952", VA = "0x7952")]
			get
			{
				return null;
			}
			[Token(Token = "0x600282E")]
			[Address(RVA = "0x1F80", Offset = "0x1F80", VA = "0x1F80")]
			set
			{
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x1F7F", Offset = "0x1F7F", VA = "0x1F7F")]
		public void SetIcon(string assetId)
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x1F7E", Offset = "0x1F7E", VA = "0x1F7E")]
		public void SetValueColor(in Color32 color)
		{
		}

		// Token: 0x1700079C RID: 1948
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079C")]
		public override TextAnchor ContainerAlign
		{
			[Token(Token = "0x6002831")]
			[Address(RVA = "0x7953", Offset = "0x7953", VA = "0x7953", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x7954", Offset = "0x7954", VA = "0x7954")]
		public TitleIconLoaderValueRow()
		{
		}

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _loader;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TextMeshProUGUI _valueField;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayoutGroup _layoutGroup;
	}
}
