using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.ContextMenu
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	public class ContextMenuController : MonoBehaviour, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x140000F4 RID: 244
		// (add) Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F4")]
		public event Action<IBaseContextMenu> ContextMenuShowEvent
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x60EC", Offset = "0x60EC", VA = "0x60EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x60ED", Offset = "0x60ED", VA = "0x60ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000F5 RID: 245
		// (add) Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F5")]
		public event Action<IBaseContextMenu> ContextMenuHideEvent
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x60EE", Offset = "0x60EE", VA = "0x60EE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x60EF", Offset = "0x60EF", VA = "0x60EF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E69")]
		public TMenu Show<TOptions, TMenu>(ContextMenuId menuId, TOptions options, Vector2 position) where TMenu : IContextMenu<TOptions>
		{
			return null;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x60F0", Offset = "0x60F0", VA = "0x60F0")]
		private void HideCurrentContextMenu()
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x60F1", Offset = "0x60F1", VA = "0x60F1")]
		public void RequestHide()
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x60F2", Offset = "0x60F2", VA = "0x60F2")]
		public void ForceHide()
		{
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x60F3", Offset = "0x60F3", VA = "0x60F3", Slot = "4")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x60F4", Offset = "0x60F4", VA = "0x60F4")]
		private void ValidateHide()
		{
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x60F5", Offset = "0x60F5", VA = "0x60F5")]
		private void HandleTargetAchievedStartEvent(GuideConfig config)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x60F6", Offset = "0x60F6", VA = "0x60F6")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x60F7", Offset = "0x60F7", VA = "0x60F7")]
		public ContextMenuController()
		{
		}

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ContextMenuConfiguration _config;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x1C")]
		private ContextMenuController _instance;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x20")]
		private IBaseContextMenu _currentContextMenu;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x2C")]
		private bool _wasDeselected;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x30")]
		public IGuideTarget GuideTarget;
	}
}
