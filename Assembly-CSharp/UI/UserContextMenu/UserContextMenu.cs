using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.ContextMenu;
using UI.UserContextMenu.ContextElements;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UserContextMenu
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class UserContextMenu : MonoBehaviour, IContextMenu<IUserMenuContext>, IBaseContextMenu
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		public IUserMenuContext Context
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x5C93", Offset = "0x5C93", VA = "0x5C93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x5C94", Offset = "0x5C94", VA = "0x5C94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x5C95", Offset = "0x5C95", VA = "0x5C95")]
		public static List<AbstractUserContextMenuElement> GetAllElements()
		{
			return null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x5C96", Offset = "0x5C96", VA = "0x5C96", Slot = "4")]
		public void Show(IUserMenuContext context)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x5C97", Offset = "0x5C97", VA = "0x5C97")]
		private void ElementOnSelectEvent(UserContextMenuElement element)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x5C98", Offset = "0x5C98", VA = "0x5C98")]
		private void OnDestroy()
		{
		}

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D1")]
		public event Action CloseEvent
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x5C99", Offset = "0x5C99", VA = "0x5C99")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x5C9A", Offset = "0x5C9A", VA = "0x5C9A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x17000127")]
		public Vector2 MenuSize
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x5C9B", Offset = "0x5C9B", VA = "0x5C9B", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000128")]
		public GameObject GameObject
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x5C9C", Offset = "0x5C9C", VA = "0x5C9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x5C9D", Offset = "0x5C9D", VA = "0x5C9D")]
		public UserContextMenu()
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x5C9E", Offset = "0x5C9E", VA = "0x5C9E", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x5C9F", Offset = "0x5C9F", VA = "0x5C9F", Slot = "7")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		public const ContextMenuId MenuId = ContextMenuId.Users;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _itemTitleLabel;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _itemView;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserContextMenuElement[] _elements;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _menuSize;

		// Token: 0x02000128 RID: 296
		[Token(Token = "0x2000128")]
		public class MenuContext : IUserMenuContext
		{
			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000921 RID: 2337 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000129")]
			public UserData User
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x5CA0", Offset = "0x5CA0", VA = "0x5CA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000922")]
				[Address(RVA = "0x5CA1", Offset = "0x5CA1", VA = "0x5CA1", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x5CA2", Offset = "0x5CA2", VA = "0x5CA2")]
			public MenuContext()
			{
			}
		}
	}
}
