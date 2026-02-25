using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Auchan.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	[RequireComponent(typeof(ArtifactView))]
	public class AuchanArtifactView : MonoBehaviour
	{
		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD3")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x6004E28")]
			[Address(RVA = "0x9C5B", Offset = "0x9C5B", VA = "0x9C5B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD4")]
		public Image Marker
		{
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x9C5C", Offset = "0x9C5C", VA = "0x9C5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FD5")]
		public AuchanArtifactData ArtifactData
		{
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x9C5D", Offset = "0x9C5D", VA = "0x9C5D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E2B")]
			[Address(RVA = "0x9C5E", Offset = "0x9C5E", VA = "0x9C5E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x9C5F", Offset = "0x9C5F", VA = "0x9C5F")]
		public void SetArtifactData(AuchanArtifactData data, UserData user, Sprite[] sprites)
		{
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x9C60", Offset = "0x9C60", VA = "0x9C60")]
		public AuchanArtifactView()
		{
		}

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _marker;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _marketAccountIcon;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x1C")]
		private ArtifactView _artifactView;
	}
}
