using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public class GenericSubFilterView : MonoBehaviour
	{
		// Token: 0x140000F2 RID: 242
		// (add) Token: 0x06000E0D RID: 3597 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F2")]
		public event Action<SubFilterListElement> ClickedEvent
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x60A0", Offset = "0x60A0", VA = "0x60A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x60A1", Offset = "0x60A1", VA = "0x60A1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x60A2", Offset = "0x60A2", VA = "0x60A2")]
		public void Init(IList<SubFilterListElement.SubFilterData> subFilterData)
		{
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x60A3", Offset = "0x60A3", VA = "0x60A3")]
		public void SelectByIndexSilent(int index)
		{
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x60A4", Offset = "0x60A4", VA = "0x60A4")]
		public SubFilterListElement GetElementByIndex(int index)
		{
			return null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x60A5", Offset = "0x60A5", VA = "0x60A5")]
		private void InstanceClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x60A6", Offset = "0x60A6", VA = "0x60A6")]
		public GenericSubFilterView()
		{
		}

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SubFilterListElement _listElementPrefab;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x18")]
		private List<SubFilterListElement> _instances;
	}
}
