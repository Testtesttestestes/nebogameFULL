using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public abstract class AbstractDataRenderer<T> : AbstractDeferredRenderer
	{
		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060007D9 RID: 2009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C6")]
		public event Action DataChangedEvent
		{
			[Token(Token = "0x60007D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007D9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x170000EB")]
		protected virtual bool ValidateDataImmediately
		{
			[Token(Token = "0x60007DA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EC")]
		public virtual T Data
		{
			[Token(Token = "0x60007DB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DC")]
			set
			{
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		public override void Dispose()
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E0")]
		private void InvalidateData()
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E1")]
		protected virtual void OnDataInvalidated()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		protected virtual void StartListenEvents(T data)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		protected virtual void StopListenEvents(T data)
		{
		}

		// Token: 0x060007E4 RID: 2020
		[Token(Token = "0x60007E4")]
		protected abstract void HandleDataChanged();

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E5")]
		protected override void CommitProperties()
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E6")]
		protected AbstractDataRenderer()
		{
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x0")]
		private bool _dataChanged;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		private T _data;
	}
}
