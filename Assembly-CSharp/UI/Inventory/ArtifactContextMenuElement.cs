using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Inventory
{
	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	public class ArtifactContextMenuElement : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F8")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x611A", Offset = "0x611A", VA = "0x611A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F9")]
		public bool ButtonBehaviour
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x611B", Offset = "0x611B", VA = "0x611B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x611C", Offset = "0x611C", VA = "0x611C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140000F6 RID: 246
		// (add) Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F6")]
		public event Action<ArtifactContextMenuElement> SelectEvent
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x611D", Offset = "0x611D", VA = "0x611D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E9D")]
			[Address(RVA = "0x2149", Offset = "0x2149", VA = "0x2149")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FA")]
		public AbstractArtifactContextMenuElement AbstractContextMenuElement
		{
			[Token(Token = "0x6000E9E")]
			[Address(RVA = "0x611E", Offset = "0x611E", VA = "0x611E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x611F", Offset = "0x611F", VA = "0x611F")]
			set
			{
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x6120", Offset = "0x6120", VA = "0x6120", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x6121", Offset = "0x6121", VA = "0x6121", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x6122", Offset = "0x6122", VA = "0x6122")]
		public ArtifactContextMenuElement()
		{
		}

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _iconLoader;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _labelGroup;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _enabledBgSprite;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _disabledBgSprite;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x28")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x34")]
		private AbstractArtifactContextMenuElement _abstractContextMenuElement;
	}
}
