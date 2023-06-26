using System;
using touching_your_mom;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UserInterface.Global.Interfaces;

namespace UserInterface.PauseMenu.Effects
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public class LabelButtonHover : MonoBehaviour, ISelectable, \u0301\u0301\u0304\u0303\u0308\u0307\u0303\u0301\u0303\u0306\u0308\u0303\u0305\u0306\u0305
	{
		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06013BC9 RID: 80841 RVA: 0x0007D39C File Offset: 0x0007B59C
		// (set) Token: 0x06013BCA RID: 80842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAF")]
		public bool isSelected
		{
			[Token(Token = "0x6013BC9")]
			[Address(RVA = "0xB51620", Offset = "0xB50A20", VA = "0x180B51620", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013BCA")]
			[Address(RVA = "0xB51CD0", Offset = "0xB510D0", VA = "0x180B51CD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06013BCB RID: 80843 RVA: 0x0007D3B4 File Offset: 0x0007B5B4
		// (set) Token: 0x06013BCC RID: 80844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB0")]
		public ButtonHoverState State
		{
			[Token(Token = "0x6013BCB")]
			[Address(RVA = "0x14C9360", Offset = "0x14C8760", VA = "0x1814C9360")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return ButtonHoverState.Idle;
			}
			[Token(Token = "0x6013BCC")]
			[Address(RVA = "0x167F4F0", Offset = "0x167E8F0", VA = "0x18167F4F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			private set
			{
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06013BCD RID: 80845 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06013BCE RID: 80846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB1")]
		public ISelectableGroup Parent
		{
			[Token(Token = "0x6013BCD")]
			[Address(RVA = "0xAEB400", Offset = "0xAEA800", VA = "0x180AEB400", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013BCE")]
			[Address(RVA = "0xC3F230", Offset = "0xC3E630", VA = "0x180C3F230", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013BCF RID: 80847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BCF")]
		[Address(RVA = "0x167EAC0", Offset = "0x167DEC0", VA = "0x18167EAC0")]
		private void Awake()
		{
		}

		// Token: 0x06013BD0 RID: 80848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD0")]
		[Address(RVA = "0x167EEC0", Offset = "0x167E2C0", VA = "0x18167EEC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06013BD1 RID: 80849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD1")]
		[Address(RVA = "0x167EE60", Offset = "0x167E260", VA = "0x18167EE60")]
		private void OnDisable()
		{
		}

		// Token: 0x06013BD2 RID: 80850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD2")]
		[Address(RVA = "0x167EB50", Offset = "0x167DF50", VA = "0x18167EB50")]
		private void ConnectEvents()
		{
		}

		// Token: 0x06013BD3 RID: 80851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD3")]
		[Address(RVA = "0x167F0F0", Offset = "0x167E4F0", VA = "0x18167F0F0")]
		private void OnPointerClick(BaseEventData data)
		{
		}

		// Token: 0x06013BD4 RID: 80852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD4")]
		[Address(RVA = "0x167F100", Offset = "0x167E500", VA = "0x18167F100")]
		private void OnPointerEnter(BaseEventData data)
		{
		}

		// Token: 0x06013BD5 RID: 80853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD5")]
		[Address(RVA = "0x167F190", Offset = "0x167E590", VA = "0x18167F190")]
		private void OnPointerExit(BaseEventData data)
		{
		}

		// Token: 0x06013BD6 RID: 80854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD6")]
		[Address(RVA = "0x167F1A0", Offset = "0x167E5A0", VA = "0x18167F1A0", Slot = "4")]
		public void Select()
		{
		}

		// Token: 0x06013BD7 RID: 80855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD7")]
		[Address(RVA = "0x167EE50", Offset = "0x167E250", VA = "0x18167EE50", Slot = "5")]
		public void Deselect()
		{
		}

		// Token: 0x06013BD8 RID: 80856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD8")]
		[Address(RVA = "0x167F2F0", Offset = "0x167E6F0", VA = "0x18167F2F0")]
		private void StateClick()
		{
		}

		// Token: 0x06013BD9 RID: 80857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BD9")]
		[Address(RVA = "0x167F100", Offset = "0x167E500", VA = "0x18167F100")]
		private void StateEnter()
		{
		}

		// Token: 0x06013BDA RID: 80858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BDA")]
		[Address(RVA = "0x167F380", Offset = "0x167E780", VA = "0x18167F380")]
		private void StateExit()
		{
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06013BDB RID: 80859 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		// (set) Token: 0x06013BDC RID: 80860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB2")]
		public int TickIndex8
		{
			[Token(Token = "0x6013BDB")]
			[Address(RVA = "0x95F3C0", Offset = "0x95E7C0", VA = "0x18095F3C0", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6013BDC")]
			[Address(RVA = "0x95F420", Offset = "0x95E820", VA = "0x18095F420", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06013BDD RID: 80861 RVA: 0x0007D3E4 File Offset: 0x0007B5E4
		// (set) Token: 0x06013BDE RID: 80862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB3")]
		public bool TickIndex8Active
		{
			[Token(Token = "0x6013BDD")]
			[Address(RVA = "0x95F3B0", Offset = "0x95E7B0", VA = "0x18095F3B0", Slot = "11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013BDE")]
			[Address(RVA = "0x95F410", Offset = "0x95E810", VA = "0x18095F410", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
			set
			{
			}
		}

		// Token: 0x06013BDF RID: 80863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BDF")]
		[Address(RVA = "0x167EF20", Offset = "0x167E320", VA = "0x18167EF20", Slot = "13")]
		public void OnLateUpdateUIUpdate()
		{
		}

		// Token: 0x06013BE0 RID: 80864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013BE0")]
		[Address(RVA = "0x167F410", Offset = "0x167E810", VA = "0x18167F410")]
		public LabelButtonHover()
		{
		}

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x165650", Offset = "0x164A50")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x04003A49 RID: 14921
		[Token(Token = "0x4003A49")]
		[FieldOffset(Offset = "0x20")]
		public CanvasGroup Hover;

		// Token: 0x04003A4A RID: 14922
		[Token(Token = "0x4003A4A")]
		[FieldOffset(Offset = "0x28")]
		private bool includeHover;

		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		[FieldOffset(Offset = "0x2C")]
		public float Idle_HoverAlpha;

		// Token: 0x04003A4C RID: 14924
		[Token(Token = "0x4003A4C")]
		[FieldOffset(Offset = "0x30")]
		public float Enter_HoverAlpha;

		// Token: 0x04003A4D RID: 14925
		[Token(Token = "0x4003A4D")]
		[FieldOffset(Offset = "0x34")]
		public float Click_HoverAlpha;

		// Token: 0x04003A4E RID: 14926
		[Token(Token = "0x4003A4E")]
		[FieldOffset(Offset = "0x38")]
		public bool includeFont;

		// Token: 0x04003A4F RID: 14927
		[Token(Token = "0x4003A4F")]
		[FieldOffset(Offset = "0x3C")]
		public FontStyles Idle_MainStyle;

		// Token: 0x04003A50 RID: 14928
		[Token(Token = "0x4003A50")]
		[FieldOffset(Offset = "0x40")]
		public FontStyles Enter_MainStyle;

		// Token: 0x04003A51 RID: 14929
		[Token(Token = "0x4003A51")]
		[FieldOffset(Offset = "0x44")]
		public FontStyles Click_MainStyle;

		// Token: 0x04003A52 RID: 14930
		[Token(Token = "0x4003A52")]
		[FieldOffset(Offset = "0x48")]
		public Color Idle_MainColor;

		// Token: 0x04003A53 RID: 14931
		[Token(Token = "0x4003A53")]
		[FieldOffset(Offset = "0x58")]
		public Color Enter_MainColor;

		// Token: 0x04003A54 RID: 14932
		[Token(Token = "0x4003A54")]
		[FieldOffset(Offset = "0x68")]
		public Color Click_MainColor;

		// Token: 0x04003A55 RID: 14933
		[Token(Token = "0x4003A55")]
		[FieldOffset(Offset = "0x78")]
		public bool StartAsClicked;

		// Token: 0x04003A56 RID: 14934
		[Token(Token = "0x4003A56")]
		[FieldOffset(Offset = "0x79")]
		public bool isSelectable;

		// Token: 0x04003A57 RID: 14935
		[Token(Token = "0x4003A57")]
		[FieldOffset(Offset = "0x7A")]
		public bool UseLerp;

		// Token: 0x04003A58 RID: 14936
		[Token(Token = "0x4003A58")]
		[FieldOffset(Offset = "0x7C")]
		public float LerpSpeed;

		// Token: 0x04003A59 RID: 14937
		[Token(Token = "0x4003A59")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent OnButtonSelected;

		// Token: 0x04003A5A RID: 14938
		[Token(Token = "0x4003A5A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <isSelected>k__BackingField;

		// Token: 0x04003A5B RID: 14939
		[Token(Token = "0x4003A5B")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private ButtonHoverState <State>k__BackingField;

		// Token: 0x04003A5C RID: 14940
		[Token(Token = "0x4003A5C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private ISelectableGroup <Parent>k__BackingField;

		// Token: 0x04003A5D RID: 14941
		[Token(Token = "0x4003A5D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private int <TickIndex8>k__BackingField;

		// Token: 0x04003A5E RID: 14942
		[Token(Token = "0x4003A5E")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x13E5B0", Offset = "0x13D9B0")]
		private bool <TickIndex8Active>k__BackingField;
	}
}
