using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	public class AudioController : AbstractController<AudioModel, AudioEvents>, IGameAudio
	{
		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06004DEF RID: 19951 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DF0 RID: 19952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCF")]
		private Coroutine _detectCoroutine
		{
			[Token(Token = "0x6004DEF")]
			[Address(RVA = "0x9C27", Offset = "0x9C27", VA = "0x9C27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DF0")]
			[Address(RVA = "0x9C28", Offset = "0x9C28", VA = "0x9C28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x9C29", Offset = "0x9C29", VA = "0x9C29")]
		public AudioController(AudioModel model, AudioEvents events)
		{
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x9C2A", Offset = "0x9C2A", VA = "0x9C2A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x9C2B", Offset = "0x9C2B", VA = "0x9C2B", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x9C2C", Offset = "0x9C2C", VA = "0x9C2C")]
		private IEnumerator MusicClipFinishDetectorCoroutine(AssetDic assetDic, float length)
		{
			return null;
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x9C2D", Offset = "0x9C2D", VA = "0x9C2D")]
		private AssetDic GetPlayListItem(AssetDic[] playlist, AssetDic currentItem)
		{
			return null;
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x9C2E", Offset = "0x9C2E", VA = "0x9C2E")]
		private void PlayMusic()
		{
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x9C2F", Offset = "0x9C2F", VA = "0x9C2F")]
		public void SetSoundFXEnabled(bool value)
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x9C30", Offset = "0x9C30", VA = "0x9C30")]
		public void SetMusicEnabled(bool value)
		{
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x38E4", Offset = "0x38E4", VA = "0x38E4", Slot = "13")]
		public void PlaySound(Sounds sound)
		{
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x9C31", Offset = "0x9C31", VA = "0x9C31", Slot = "14")]
		public void PlaySound(AssetDic asset)
		{
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x9C32", Offset = "0x9C32", VA = "0x9C32", Slot = "12")]
		public void PlayMusic(PlayLists playlistName)
		{
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x9C33", Offset = "0x9C33", VA = "0x9C33")]
		public void PlayMusic(AssetDic asset)
		{
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x9C34", Offset = "0x9C34", VA = "0x9C34", Slot = "15")]
		public void StopMusic()
		{
		}

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<long> _musicAudioCacheOperationsIndexes;
	}
}
