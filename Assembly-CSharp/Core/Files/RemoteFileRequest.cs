using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Log.Files;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace Core.Files
{
	// Token: 0x02000EF9 RID: 3833
	[Token(Token = "0x2000EF9")]
	public class RemoteFileRequest : IFileInfo, IFileContent
	{
		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C7")]
		public string Path
		{
			[Token(Token = "0x6005CEF")]
			[Address(RVA = "0xA978", Offset = "0xA978", VA = "0xA978", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x170012C8")]
		public bool CacheOnDevice
		{
			[Token(Token = "0x6005CF0")]
			[Address(RVA = "0xA979", Offset = "0xA979", VA = "0xA979", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012C9")]
		public IFileInfo FileInfo
		{
			[Token(Token = "0x6005CF1")]
			[Address(RVA = "0xA97A", Offset = "0xA97A", VA = "0xA97A", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012CA")]
		[CanBeNull]
		public UnityWebRequest UwRequest
		{
			[Token(Token = "0x6005CF2")]
			[Address(RVA = "0xA97B", Offset = "0xA97B", VA = "0xA97B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CF3")]
			[Address(RVA = "0xA97C", Offset = "0xA97C", VA = "0xA97C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012CB")]
		public int Attempt
		{
			[Token(Token = "0x6005CF4")]
			[Address(RVA = "0xA97D", Offset = "0xA97D", VA = "0xA97D")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005CF5")]
			[Address(RVA = "0xA97E", Offset = "0xA97E", VA = "0xA97E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0xA97F", Offset = "0xA97F", VA = "0xA97F")]
		public float GetDelayForAttempt()
		{
			return 0f;
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0xA980", Offset = "0xA980", VA = "0xA980")]
		public RemoteFileRequest(Uri uri, bool cacheOnDevice, int numberOfAttempts, Action<IFileContent> callback)
		{
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x170012CC")]
		public bool IsExpired
		{
			[Token(Token = "0x6005CF8")]
			[Address(RVA = "0xA981", Offset = "0xA981", VA = "0xA981")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0xA982", Offset = "0xA982", VA = "0xA982")]
		public void RunRequest(UnityWebRequest request)
		{
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xA983", Offset = "0xA983", VA = "0xA983")]
		public void Complete()
		{
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0xA984", Offset = "0xA984", VA = "0xA984")]
		public bool TryAddCallback(Action<IFileContent> callback)
		{
			return default(bool);
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00010B30 File Offset: 0x0000ED30
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0xA985", Offset = "0xA985", VA = "0xA985", Slot = "8")]
		private bool TryGetContent(out byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0xA986", Offset = "0xA986", VA = "0xA986", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0xA987", Offset = "0xA987", VA = "0xA987", Slot = "6")]
		public bool TryGetResponseHeader(string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x8")]
		public readonly float DefaultDelayForAttempt;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0xC")]
		public readonly int NumberOfAttempts;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x10")]
		public readonly Uri Uri;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x14")]
		[CanBeNull]
		public FileDownloadLogger FileDownloadLogger;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x18")]
		private readonly LinkedList<Action<IFileContent>> _callbacks;
	}
}
