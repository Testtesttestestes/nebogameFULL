using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Data;
using Core.Data.User;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Sound.Model
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000C74")]
	public class AudioModel : AbstractModel
	{
		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC5")]
		public IUserSettings UserSettings
		{
			[Token(Token = "0x6004DD3")]
			[Address(RVA = "0x9C0B", Offset = "0x9C0B", VA = "0x9C0B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DD4")]
			[Address(RVA = "0x9C0C", Offset = "0x9C0C", VA = "0x9C0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06004DD5 RID: 19925 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DD6 RID: 19926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC6")]
		public ICache<AssetDic, AudioClip> AudioCache
		{
			[Token(Token = "0x6004DD5")]
			[Address(RVA = "0x9C0D", Offset = "0x9C0D", VA = "0x9C0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DD6")]
			[Address(RVA = "0x9C0E", Offset = "0x9C0E", VA = "0x9C0E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DD8 RID: 19928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC7")]
		public DictManager DictManager
		{
			[Token(Token = "0x6004DD7")]
			[Address(RVA = "0x9C0F", Offset = "0x9C0F", VA = "0x9C0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DD8")]
			[Address(RVA = "0x9C10", Offset = "0x9C10", VA = "0x9C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x0000E478 File Offset: 0x0000C678
		// (set) Token: 0x06004DDA RID: 19930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC8")]
		public PlayLists CurrentPlayList
		{
			[Token(Token = "0x6004DD9")]
			[Address(RVA = "0x9C11", Offset = "0x9C11", VA = "0x9C11")]
			[CompilerGenerated]
			get
			{
				return PlayLists.UNKNOWN;
			}
			[Token(Token = "0x6004DDA")]
			[Address(RVA = "0x9C12", Offset = "0x9C12", VA = "0x9C12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06004DDB RID: 19931 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004DDC RID: 19932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC9")]
		public AssetDic CurrentMusic
		{
			[Token(Token = "0x6004DDB")]
			[Address(RVA = "0x9C13", Offset = "0x9C13", VA = "0x9C13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DDC")]
			[Address(RVA = "0x9C14", Offset = "0x9C14", VA = "0x9C14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06004DDD RID: 19933 RVA: 0x0000E490 File Offset: 0x0000C690
		// (set) Token: 0x06004DDE RID: 19934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCA")]
		public float FadeOutDuration
		{
			[Token(Token = "0x6004DDD")]
			[Address(RVA = "0x9C15", Offset = "0x9C15", VA = "0x9C15")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004DDE")]
			[Address(RVA = "0x9C16", Offset = "0x9C16", VA = "0x9C16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x06004DE0 RID: 19936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCB")]
		public float FadeInDuration
		{
			[Token(Token = "0x6004DDF")]
			[Address(RVA = "0x9C17", Offset = "0x9C17", VA = "0x9C17")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004DE0")]
			[Address(RVA = "0x9C18", Offset = "0x9C18", VA = "0x9C18")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		// (set) Token: 0x06004DE2 RID: 19938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCC")]
		public float VolumeOn
		{
			[Token(Token = "0x6004DE1")]
			[Address(RVA = "0x9C19", Offset = "0x9C19", VA = "0x9C19")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004DE2")]
			[Address(RVA = "0x9C1A", Offset = "0x9C1A", VA = "0x9C1A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCD")]
		public float VolumeOff
		{
			[Token(Token = "0x6004DE3")]
			[Address(RVA = "0x9C1B", Offset = "0x9C1B", VA = "0x9C1B")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004DE4")]
			[Address(RVA = "0x9C1C", Offset = "0x9C1C", VA = "0x9C1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x9C1D", Offset = "0x9C1D", VA = "0x9C1D", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x9C1E", Offset = "0x9C1E", VA = "0x9C1E")]
		public AudioModel(IUserSettings userSettings, ICache<AssetDic, AudioClip> audioCache, DictManager dictManager, UserData user)
		{
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x9C1F", Offset = "0x9C1F", VA = "0x9C1F")]
		public bool TryGetSoundAsset(string key, out AssetDic asset)
		{
			return default(bool);
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x9C20", Offset = "0x9C20", VA = "0x9C20")]
		public bool TryGetPlayListAssets(string name, out AssetDic[] assets)
		{
			return default(bool);
		}

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x30")]
		public readonly string MusicVolumeName;

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<string, AssetDic> _soundAssetsCacheByKey;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, AssetDic[]> _playListAssetsCacheByName;
	}
}
