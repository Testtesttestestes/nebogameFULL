using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public class SkillRow : TitleIconValueBackground, IToolTipDataProvider, IDisposable
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x69AE", Offset = "0x69AE", VA = "0x69AE")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042B")]
		public UserData User
		{
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x69AF", Offset = "0x69AF", VA = "0x69AF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F5")]
			[Address(RVA = "0x69B0", Offset = "0x69B0", VA = "0x69B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x69B1", Offset = "0x69B1", VA = "0x69B1")]
		public void Init(UserData user, UserSkillDic userSkillDic, SkillData skillData)
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x69B2", Offset = "0x69B2", VA = "0x69B2")]
		public void SetUserSkillDic(UserSkillDic value)
		{
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x69B3", Offset = "0x69B3", VA = "0x69B3", Slot = "6")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x69B4", Offset = "0x69B4", VA = "0x69B4", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x69B5", Offset = "0x69B5", VA = "0x69B5")]
		public SkillRow()
		{
		}

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x38")]
		private UserSkillDic _skillDic;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x3C")]
		private SkillData _skillData;
	}
}
