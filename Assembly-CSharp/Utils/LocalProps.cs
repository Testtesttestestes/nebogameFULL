using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Utils
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Serializable]
	public class LocalProps
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4472", Offset = "0x4472", VA = "0x4472")]
		public LocalProps(string storageName, string defaultVersion)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x56F0", Offset = "0x56F0", VA = "0x56F0")]
		private bool TryGetProp(string scope, string name, out LocalProps.Data data, [CanBeNull] [Optional] string version)
		{
			return default(bool);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1D82", Offset = "0x1D82", VA = "0x1D82")]
		public LocalProps SetProp(string scope, string name, string value, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x56F1", Offset = "0x56F1", VA = "0x56F1")]
		public LocalProps SetProp(string scope, string name, long value, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1D7C", Offset = "0x1D7C", VA = "0x1D7C")]
		public bool TryGetProp(string scope, string name, out string value, [CanBeNull] [Optional] string version)
		{
			return default(bool);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x56F2", Offset = "0x56F2", VA = "0x56F2")]
		public bool TryGetProp(string scope, string name, out long value, [CanBeNull] [Optional] string version)
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x56F3", Offset = "0x56F3", VA = "0x56F3")]
		public void GetOrCreate(string scope, string name, out long value, [CanBeNull] [Optional] string version)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x56F4", Offset = "0x56F4", VA = "0x56F4")]
		public string GetOrCreate(string scope, string name, out string value, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x56F5", Offset = "0x56F5", VA = "0x56F5")]
		public LocalProps Remove(string scope, string name, [CanBeNull] [Optional] string version)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4474", Offset = "0x4474", VA = "0x4474")]
		public LocalProps Reset()
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1D83", Offset = "0x1D83", VA = "0x1D83")]
		public LocalProps Commit()
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4473", Offset = "0x4473", VA = "0x4473")]
		public LocalProps Load()
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x56F6", Offset = "0x56F6", VA = "0x56F6", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<LocalProps.Data> _data;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string StorageName;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string DefaultVersion;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public enum Scopes
		{
			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			User,
			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			OneOnOneCombat,
			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			Application
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public enum Names
		{
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			ReceivedNewUserLevelForNotify,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			IsShowUserSkills,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			IsShowNYSnowFx,
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			IsShowNYWindy,
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			PreloaderSkinJson
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		[Serializable]
		private class Data
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600025A RID: 602 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005E")]
			[JsonProperty("scope")]
			public string Scope
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x56F7", Offset = "0x56F7", VA = "0x56F7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005F")]
			[JsonProperty("name")]
			public string Name
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x56F8", Offset = "0x56F8", VA = "0x56F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600025C RID: 604 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000060")]
			[JsonProperty("version")]
			public string Version
			{
				[Token(Token = "0x600025C")]
				[Address(RVA = "0x56F9", Offset = "0x56F9", VA = "0x56F9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600025D RID: 605 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000061")]
			public string Value
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x56FA", Offset = "0x56FA", VA = "0x56FA")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x56FB", Offset = "0x56FB", VA = "0x56FB")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x56FC", Offset = "0x56FC", VA = "0x56FC")]
			public Data(string scope, string name, string value, string version)
			{
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x56FD", Offset = "0x56FD", VA = "0x56FD")]
			public void SetValue(string value)
			{
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x56FE", Offset = "0x56FE", VA = "0x56FE", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}
	}
}
