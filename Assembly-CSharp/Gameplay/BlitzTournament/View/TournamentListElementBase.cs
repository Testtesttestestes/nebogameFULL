using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AssetContent;
using Core.Data.Tournaments;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x2000BCF")]
	public abstract class TournamentListElementBase<T> : TournamentListElementBase where T : ITournament
	{
		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFC")]
		public T TournamentData
		{
			[Token(Token = "0x6004A13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A15")]
		public virtual void Init(int index, T tournamentData, [Optional] Action<TournamentListElementBase> onClick)
		{
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A16")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x06004A17 RID: 18967
		[Token(Token = "0x6004A17")]
		public abstract void UpdateView();

		// Token: 0x06004A18 RID: 18968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A18")]
		protected TournamentListElementBase()
		{
		}

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameRawImage _banner;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Image _selectedImage;

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Image _selectedImageTop;

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Image _borderImage;
	}
}
