using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Assistants.Model
{
	// Token: 0x02000CA8 RID: 3240
	[Token(Token = "0x2000CA8")]
	public abstract class BaseAssistantModel : AbstractModel
	{
		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF4")]
		public IGame Game
		{
			[Token(Token = "0x6004ECE")]
			[Address(RVA = "0x9CF6", Offset = "0x9CF6", VA = "0x9CF6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ECF")]
			[Address(RVA = "0x9CF7", Offset = "0x9CF7", VA = "0x9CF7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF5")]
		public AssistantsDic Dic
		{
			[Token(Token = "0x6004ED0")]
			[Address(RVA = "0x9CF8", Offset = "0x9CF8", VA = "0x9CF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED1")]
			[Address(RVA = "0x9CF9", Offset = "0x9CF9", VA = "0x9CF9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x9CFA", Offset = "0x9CFA", VA = "0x9CFA", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x9CFB", Offset = "0x9CFB", VA = "0x9CFB")]
		protected BaseAssistantModel(AssistantsDic dic, AssistantStatus status, IGame game, UserData user)
		{
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ED5 RID: 20181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF6")]
		public AssistantStatus Status
		{
			[Token(Token = "0x6004ED4")]
			[Address(RVA = "0x9CFC", Offset = "0x9CFC", VA = "0x9CFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED5")]
			[Address(RVA = "0x9CFD", Offset = "0x9CFD", VA = "0x9CFD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x17000FF7")]
		public virtual bool IsIdle
		{
			[Token(Token = "0x6004ED6")]
			[Address(RVA = "0x9CFE", Offset = "0x9CFE", VA = "0x9CFE", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x17000FF8")]
		public virtual bool IsActive
		{
			[Token(Token = "0x6004ED7")]
			[Address(RVA = "0x9CFF", Offset = "0x9CFF", VA = "0x9CFF", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x17000FF9")]
		public virtual bool IsPause
		{
			[Token(Token = "0x6004ED8")]
			[Address(RVA = "0x9D00", Offset = "0x9D00", VA = "0x9D00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x17000FFA")]
		public virtual bool IsFinish
		{
			[Token(Token = "0x6004ED9")]
			[Address(RVA = "0x9D01", Offset = "0x9D01", VA = "0x9D01", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06004EDA RID: 20186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FFB")]
		public BackTime WorkBacktime
		{
			[Token(Token = "0x6004EDA")]
			[Address(RVA = "0x9D02", Offset = "0x9D02", VA = "0x9D02")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
