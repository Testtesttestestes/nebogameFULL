using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Trackers
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Serializable]
	public class AsyncLoadableContentTracker : IAsyncLoadableContent, IDisposable
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x5777", Offset = "0x5777", VA = "0x5777", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x5778", Offset = "0x5778", VA = "0x5778", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		private IAsyncLoadableContent[] Loaders
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x5779", Offset = "0x5779", VA = "0x5779")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000077")]
		public bool IsReady
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x577A", Offset = "0x577A", VA = "0x577A", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x577B", Offset = "0x577B", VA = "0x577B")]
		public void Init(IEnumerable<IAsyncLoadableContent> loaders)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x577C", Offset = "0x577C", VA = "0x577C")]
		public void StartTracking()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x577D", Offset = "0x577D", VA = "0x577D")]
		public void StopTracking()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x577E", Offset = "0x577E", VA = "0x577E")]
		private void LoaderReadyEventHandler(IAsyncLoadableContent loader)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x577F", Offset = "0x577F", VA = "0x577F")]
		private void NotifyIfReady()
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5780", Offset = "0x5780", VA = "0x5780", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x5781", Offset = "0x5781", VA = "0x5781")]
		public AsyncLoadableContentTracker()
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Уведомляет, когда доля загруженных ассетов больше данного порога")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _threshold;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x10")]
		private bool _isReady;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x11")]
		private bool _isTracking;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x14")]
		private IAsyncLoadableContent[] _loaders;
	}
}
