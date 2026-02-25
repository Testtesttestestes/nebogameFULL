using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Files;
using Core.Gameplay.Managers.Configuration;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.AssetBundles
{
	// Token: 0x02001110 RID: 4368
	[Token(Token = "0x2001110")]
	public abstract class AbstractAssetBundleLoader : IDisposable
	{
		// Token: 0x14000245 RID: 581
		// (add) Token: 0x060065E6 RID: 26086 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060065E7 RID: 26087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000245")]
		private event Action<string> DisposeCompleteEvent
		{
			[Token(Token = "0x60065E6")]
			[Address(RVA = "0xB16F", Offset = "0xB16F", VA = "0xB16F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60065E7")]
			[Address(RVA = "0xB170", Offset = "0xB170", VA = "0xB170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0xB171", Offset = "0xB171", VA = "0xB171")]
		public void DisposeOnLoad(Action<string> callback)
		{
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0xB172", Offset = "0xB172", VA = "0xB172")]
		public void DontDisposeOnLoad()
		{
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0xB173", Offset = "0xB173", VA = "0xB173")]
		protected AbstractAssetBundleLoader(IFileManager fileProvider, IPlatformConfigurationProvider configurationProvider, string platformName, string path, bool cacheOnDevice)
		{
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x446B", Offset = "0x446B", VA = "0x446B")]
		public void Load()
		{
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0xB174", Offset = "0xB174", VA = "0xB174")]
		private void OnAssetBundleBytesReady(IFileContent content)
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0xB175", Offset = "0xB175", VA = "0xB175", Slot = "5")]
		protected virtual void CreateAssetBundleFromBytes(byte[] bytes)
		{
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0xB176", Offset = "0xB176", VA = "0xB176", Slot = "6")]
		protected virtual UniTaskVoid LoadFromMemoryAsync(byte[] bytes)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x446A", Offset = "0x446A", VA = "0x446A")]
		public void AddCallback(Action<AssetBundle> successCallback, Action failCallback)
		{
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x2279", Offset = "0x2279", VA = "0x2279")]
		protected void CheckIfReady()
		{
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0xB177", Offset = "0xB177", VA = "0xB177", Slot = "7")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0xB178", Offset = "0xB178", VA = "0xB178")]
		[CompilerGenerated]
		internal static string <Load>g__GetBundleUrlByResourceUrl|22_0(string platformName, string url)
		{
			return null;
		}

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		private const string UnityPackageExtension = ".unitypackage";

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		private const string Unity3dExtension = ".unity3d";

		// Token: 0x04003673 RID: 13939
		[Token(Token = "0x4003673")]
		private const string BundlesDir = "bundles/";

		// Token: 0x04003674 RID: 13940
		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0x8")]
		private bool _isDisposed;

		// Token: 0x04003675 RID: 13941
		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x9")]
		public readonly bool CacheOnDevice;

		// Token: 0x04003676 RID: 13942
		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _path;

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _platformName;

		// Token: 0x04003678 RID: 13944
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x14")]
		private readonly IFileManager _fileProvider;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x18")]
		private readonly IPlatformConfigurationProvider _configurationProvider;

		// Token: 0x0400367B RID: 13947
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x20")]
		public int Counter;

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x24")]
		private AssetBundle _bundle;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<Action<AssetBundle>> _successCallbacks;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<Action> _failCallbacks;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x30")]
		private bool _failed;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x31")]
		private bool _isLoading;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x32")]
		private bool _disposeOnLoad;
	}
}
