using System;
using System.Runtime.CompilerServices;
using Core.Dict;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	public abstract class AbstractTag : IDisposable
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E6")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6002E39")]
			[Address(RVA = "0x7EB5", Offset = "0x7EB5", VA = "0x7EB5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E3A")]
			[Address(RVA = "0x7EB6", Offset = "0x7EB6", VA = "0x7EB6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x170008E7")]
		public uint Id
		{
			[Token(Token = "0x6002E3B")]
			[Address(RVA = "0x7EB7", Offset = "0x7EB7", VA = "0x7EB7")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x170008E8")]
		public virtual uint Len
		{
			[Token(Token = "0x6002E3C")]
			[Address(RVA = "0x7EB8", Offset = "0x7EB8", VA = "0x7EB8", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008E9")]
		public virtual RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002E3D")]
			[Address(RVA = "0x7EB9", Offset = "0x7EB9", VA = "0x7EB9", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x00008F28 File Offset: 0x00007128
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EA")]
		public int Index
		{
			[Token(Token = "0x6002E3E")]
			[Address(RVA = "0x7EBA", Offset = "0x7EBA", VA = "0x7EBA")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E3F")]
			[Address(RVA = "0x7EBB", Offset = "0x7EBB", VA = "0x7EBB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008EB")]
		public double[] EventNumberParams
		{
			[Token(Token = "0x6002E40")]
			[Address(RVA = "0x7EBC", Offset = "0x7EBC", VA = "0x7EBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E41")]
			[Address(RVA = "0x7EBD", Offset = "0x7EBD", VA = "0x7EBD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x7EBE", Offset = "0x7EBE", VA = "0x7EBE")]
		public bool IsSupport(string tagName)
		{
			return default(bool);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x7EBF", Offset = "0x7EBF", VA = "0x7EBF", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x7EC0", Offset = "0x7EC0", VA = "0x7EC0", Slot = "7")]
		public virtual bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E45")]
		protected T GetView<T>(string path, Transform parent) where T : Component
		{
			return null;
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x7EC1", Offset = "0x7EC1", VA = "0x7EC1")]
		protected AbstractTag()
		{
		}

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		public const string LOAD_VIEW_ROOT_PATH = "Prefabs/UI/GameEvents";

		// Token: 0x04001960 RID: 6496
		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0xC")]
		public EventTagDic EventTagDic;

		// Token: 0x02000796 RID: 1942
		[Token(Token = "0x2000796")]
		public class TagViewHandler
		{
			// Token: 0x06002E47 RID: 11847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E47")]
			[Address(RVA = "0x7EC2", Offset = "0x7EC2", VA = "0x7EC2")]
			public TagViewHandler()
			{
			}

			// Token: 0x04001963 RID: 6499
			[Token(Token = "0x4001963")]
			[FieldOffset(Offset = "0x8")]
			public Transform Parent;

			// Token: 0x04001964 RID: 6500
			[Token(Token = "0x4001964")]
			[FieldOffset(Offset = "0xC")]
			public Action<GameObject> ViewCallback;
		}
	}
}
