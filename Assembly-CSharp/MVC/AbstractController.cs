using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace MVC
{
	// Token: 0x02000E39 RID: 3641
	[Token(Token = "0x2000E39")]
	public abstract class AbstractController : IDisposable
	{
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700122F")]
		public bool IsRun
		{
			[Token(Token = "0x6005937")]
			[Address(RVA = "0xA688", Offset = "0xA688", VA = "0xA688")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005938")]
			[Address(RVA = "0xA689", Offset = "0xA689", VA = "0xA689")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06005939 RID: 22841 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		// (set) Token: 0x0600593A RID: 22842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001230")]
		public bool IsInit
		{
			[Token(Token = "0x6005939")]
			[Address(RVA = "0xA68A", Offset = "0xA68A", VA = "0xA68A")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600593A")]
			[Address(RVA = "0xA68B", Offset = "0xA68B", VA = "0xA68B")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001231")]
		public bool IsDisposed
		{
			[Token(Token = "0x600593B")]
			[Address(RVA = "0xA68C", Offset = "0xA68C", VA = "0xA68C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600593C")]
			[Address(RVA = "0xA68D", Offset = "0xA68D", VA = "0xA68D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593D")]
		[Address(RVA = "0xA68E", Offset = "0xA68E", VA = "0xA68E", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593E")]
		[Address(RVA = "0xA68F", Offset = "0xA68F", VA = "0xA68F")]
		public void Run()
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593F")]
		[Address(RVA = "0xA690", Offset = "0xA690", VA = "0xA690")]
		public void Stop()
		{
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005940")]
		[Address(RVA = "0xA691", Offset = "0xA691", VA = "0xA691")]
		private void CancelRequests()
		{
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005941")]
		[Address(RVA = "0x1AEF", Offset = "0x1AEF", VA = "0x1AEF")]
		protected void AddRequestToken(IOpToken token)
		{
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005942")]
		[Address(RVA = "0xA692", Offset = "0xA692", VA = "0xA692")]
		protected void RemoveRequestToken(IOpToken token)
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005943")]
		[Address(RVA = "0xA693", Offset = "0xA693", VA = "0xA693", Slot = "6")]
		protected virtual void HandleStop()
		{
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x36D6", Offset = "0x36D6", VA = "0x36D6", Slot = "7")]
		protected virtual void HandleRun()
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005945")]
		[Address(RVA = "0xA694", Offset = "0xA694", VA = "0xA694")]
		protected AbstractController()
		{
		}

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0xC")]
		private readonly OpTokenRepository _tokenRepository;
	}
}
