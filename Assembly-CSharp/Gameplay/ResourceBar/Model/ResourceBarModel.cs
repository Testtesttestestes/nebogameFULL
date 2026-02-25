using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.ResourceBar.Model
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	public class ResourceBarModel : AbstractModel
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000603")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x60020D6")]
			[Address(RVA = "0x7239", Offset = "0x7239", VA = "0x7239")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020D7")]
			[Address(RVA = "0x723A", Offset = "0x723A", VA = "0x723A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000604")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x60020D8")]
			[Address(RVA = "0x723B", Offset = "0x723B", VA = "0x723B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020D9")]
			[Address(RVA = "0x723C", Offset = "0x723C", VA = "0x723C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000605")]
		public PopupController PopupController
		{
			[Token(Token = "0x60020DA")]
			[Address(RVA = "0x723D", Offset = "0x723D", VA = "0x723D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020DB")]
			[Address(RVA = "0x723E", Offset = "0x723E", VA = "0x723E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000606")]
		public IGame Game
		{
			[Token(Token = "0x60020DC")]
			[Address(RVA = "0x723F", Offset = "0x723F", VA = "0x723F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020DD")]
			[Address(RVA = "0x7240", Offset = "0x7240", VA = "0x7240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x7241", Offset = "0x7241", VA = "0x7241", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x7242", Offset = "0x7242", VA = "0x7242")]
		public ResourceBarModel(IGame game, IRequirementValidator requirementValidator, IDictProvider dictProvider, PopupController popupController, UserData user)
		{
		}
	}
}
